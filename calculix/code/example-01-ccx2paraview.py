'''
Ejecutar como `py -3.11`

py -3.11 ".\example-01-cc2paraview.py" --ccx "%USERPROFILE%\Build-CalculiX-2.20.0-win-x64\bin\ccx.exe"
'''
# Python
import os, subprocess, random, pathlib, shutil
import traceback

# Convertidor `frd` a `vtu`. Son dos
from ccx2paraview import Converter
from frd2vtu import frd2vtu
import multiprocessing

# Input
import argparse
parser = argparse.ArgumentParser(description="CCX tool example for ParaView")
parser.add_argument("--ccx", required=True, help="ccx.exe solver file")
args = parser.parse_args()


# Directorios y archivos
cwd = os.getcwd()
desktop_echo_output = subprocess.check_output( 
    ["cmd", "/c", "echo", "%USERPROFILE%\\Desktop"],  text=True 
).strip()

CWD_DIR = pathlib.Path(cwd)
WORK_DIR = pathlib.Path( desktop_echo_output )
INPS_DIR = WORK_DIR.joinpath("paraview-inp-files")
INPUT_FRD_DIR = WORK_DIR.joinpath("paraview-input-frd-files")
OUTPUT_VTU_DIR = WORK_DIR.joinpath("paraview-output-vtu-files")

WORK_DIRS = [CWD_DIR, WORK_DIR, INPS_DIR, INPUT_FRD_DIR, OUTPUT_VTU_DIR]

CCX_EXECUTABLE_FILE = args.ccx

DICT_WORK_DIRS = {}

print("# Work dirs")
for d in WORK_DIRS:
    exists = d.exists()
    DICT_WORK_DIRS.update(
        { d.name: { "path": d, "exists": exists} }
    )
    print( f"- {d}\n    exists: {exists}" )
print()

## Crear directorios
print("# Creating dirs")
if DICT_WORK_DIRS["Desktop"]["exists"]:
    if not DICT_WORK_DIRS["paraview-input-frd-files"]["exists"]:
        os.mkdir( DICT_WORK_DIRS["paraview-input-frd-files"]["path"] )
    if not DICT_WORK_DIRS["paraview-output-vtu-files"]["exists"]:
        os.mkdir( DICT_WORK_DIRS["paraview-output-vtu-files"]["path"] )
    if not DICT_WORK_DIRS["paraview-inp-files"]["exists"]:
        os.mkdir( DICT_WORK_DIRS["paraview-inp-files"]["path"] )
print()


# Utils
def get_recursive_tree(path: object | pathlib.Path ) -> dict:
    '''
    Obtener directorio y archivos de manera recursiva. Depende del parametro `path`
    '''
    dict_path = {
        "directorys" : [], "files" : []
    }
    for dir_or_file in path.rglob('*'):
        if dir_or_file.is_dir():
            dict_path["directorys"].append( dir_or_file )
        elif dir_or_file.is_file():
            dict_path["files"].append( dir_or_file )

    return dict_path


# Process `inp` with `ccx`
def ccx_process_inp(inp_file):
    subprocess.run([CCX_EXECUTABLE_FILE, str(inp_file).replace(inp_file.suffix,"")])
    return True

# Funcs Converter
ridiculous_size_in_bytes = 20
def ccx2paraview_convert_frd_to_vtu(frd_path):
    c = Converter( str(frd_path), ["vtu"] )
    try:
        c.run()
        return True
    except Exception as e:
        print(e)
        return False

def frd2vtu_convert_frd_to_vtu(frd_path, output_dir):
    try:
        frd2vtu( [str(frd_path)], str(output_dir))
        return True
    except Exception as e:
        print(e)
        return False 

def move_vtu_files(input_dir, output_dir):
    tree = get_recursive_tree(input_dir)
    try:
        for f in tree["files"]:
            if f.suffix.lower() in [".vtu", ".pvd"]:
                target = output_dir.joinpath(f.name)
                if target.exists():
                    target.unlink()
                shutil.move( str(f), str(output_dir) )
        return True
    except Exception as e:
        print(e)
        return False

def move_frd_files(input_dir, output_dir):
    tree = get_recursive_tree(input_dir)
    try:
        for f in tree["files"]:
            if f.suffix.lower() in [".dat", ".sta", ".cvg", ".12d", ".frd"]:
                target = output_dir.joinpath(f.name)
                if target.exists():
                    target.unlink()
                shutil.move( str(f), str(output_dir) )
        return True
    except Exception as e:
        print(e)
        return False


def process_inp_files(input_dir, output_dir):
    tree_of_dir = get_recursive_tree(input_dir)
    inp_files = []
    for f in tree_of_dir["files"]:
        if f.suffix == ".inp":
            inp_files.append(f)

    if len(inp_files) == 0:
        print("Nothing bro...")
        return
    
    try:
        for i in inp_files:
            ccx_process_inp(i)
        move_frd_files(input_dir, output_dir)
    except Exception as e:
        print(e)

def convert_all_things(converter, input_dir, output_dir):
    '''
    frd2vtu, espera frd binario. No ASCII
    ccx2paraview, espera ASCII.
    '''
    tree_of_dir = get_recursive_tree(input_dir)
    frd_files = []
    for f in tree_of_dir["files"]:
        if f.suffix == ".frd":
            frd_files.append(f)
    
    if len(frd_files) == 0:
        print("Nothing bro...")
        return
    
    for frd in frd_files:
        print(f"## File: `{frd}`")
        print(f"- Using converter: {converter}")
        print(f"- Input | Output: `{input_dir}` | `{output_dir}`")
        frd_size_in_bytes = os.path.getsize(frd)
        if frd_size_in_bytes < ridiculous_size_in_bytes:
            print(f"- Ridiculous size in bytes < `{ridiculous_size_in_bytes}`. Probably bad file.")
        try:
            convert = False
            if converter == "frd2vtu":
                convert = frd2vtu_convert_frd_to_vtu(frd, output_dir)
            elif converter == "ccx2paraview":
                convert = ccx2paraview_convert_frd_to_vtu(frd)
            if convert:
                print(f"### The file `{frd}` is converted.")
                move = move_vtu_files(input_dir, output_dir)
                if move:
                    print(f"Moving vtu files to `{output_dir}`.")
        except Exception as e:
            print(f"Error converting frd to vtu: `{frd}`")
            print(e)
            #traceback.print_exc() # Error completo
        print()

if __name__ == "__main__":
    multiprocessing.freeze_support()
    print("# Process inp files")
    process_inp_files(INPS_DIR, INPUT_FRD_DIR)
    print()
    
    print("# Converting files")
    convert_all_things("ccx2paraview", INPUT_FRD_DIR, OUTPUT_VTU_DIR)
    #convert_all_things("frd2vtu", INPUT_FRD_DIR, OUTPUT_VTU_DIR)