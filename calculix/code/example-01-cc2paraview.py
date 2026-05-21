'''
Ejecutar como `py -3.11`
'''
# Python
import os, subprocess, random, pathlib, shutil
import traceback

# Convertidor `frd` a `vtu`. Son dos
from ccx2paraview import Converter
from frd2vtu import frd2vtu
import multiprocessing


# Directorios
cwd = os.getcwd()
desktop_echo_output = subprocess.check_output( 
    ["cmd", "/c", "echo", "%USERPROFILE%\\Desktop"],  text=True 
).strip()

cwd_dir = pathlib.Path(cwd)
desktop_dir = pathlib.Path( desktop_echo_output )
input_dir = desktop_dir.joinpath("paraview-input-frd-files")
output_dir = desktop_dir.joinpath("paraview-output-vtu-files")

work_dirs = [cwd_dir, desktop_dir, input_dir, output_dir]

dict_work_dirs = {}

ridiculous_size_in_bytes = 20

print("# Work dirs")
for d in work_dirs:
    exists = d.exists()
    dict_work_dirs.update(
        { d.name: { "path": d, "exists": exists} }
    )
    print( f"- {d}\n    exists: {exists}" )
print()

## Crear directorios
print("# Creating dirs")
if dict_work_dirs["Desktop"]["exists"]:
    if not dict_work_dirs["paraview-input-frd-files"]["exists"]:
        os.mkdir( dict_work_dirs["paraview-input-frd-files"]["path"] )
    if not dict_work_dirs["paraview-output-vtu-files"]["exists"]:
        os.mkdir( dict_work_dirs["paraview-output-vtu-files"]["path"] )
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
def ccx_process_inp(path):
    pass 

# Funcs Converter
def ccx2paraview_convert_frd_to_vtu(frd_path):
    c = Converter( str(frd_path), ["vtu"] )
    return c.run()

def frd2vtu_convert_frd_to_vtu(frd_path, output_dir):
    convert = frd2vtu( [str(frd_path)], str(output_dir))
    return convert

def convert_all_things(converter="frd2vtu"):
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
            print(f"Ridiculous size in bytes < `{ridiculous_size_in_bytes}`. Probably bad file.")
        try:
            convert = False
            if converter == "frd2vtu":
                convert = frd2vtu_convert_frd_to_vtu(frd, output_dir)
            elif converter == "ccx2paraview":
                convert = ccx2paraview_convert_frd_to_vtu(frd)
                name = frd.name.replace(".frd", ".vtu")
                directory = frd.parent
                vtu_file = directory.joinpath(name) 
                shutil.move(vtu_file, output_dir)
                print(f"Moving `{vtu_file}`, to `{output_dir}`")
            if convert:
                print(f"The file `{frd}` is converted.")
        except Exception as e:
            print(f"Error converting frd to vtu: `{frd}`")
            print(e)
            #traceback.print_exc() # Error completo
        print()
print("# Converting files")

if __name__ == "__main__":
    multiprocessing.freeze_support()
    convert_all_things("ccx2paraview")