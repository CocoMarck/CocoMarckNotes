'''
Ejecutar como `py -3.11`
'''
# Python
import os, subprocess, random, pathlib, shutil

# Convertidor `frd` a `vtu`
from ccx2paraview import Converter

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
        "directory" : [], "file" : []
    }
    for dir_or_file in path.rglob('*'):
        if dir_or_file.is_dir():
            dict_path["directory"].append( dir_or_file )
        elif dir_or_file.is_file():
            dict_path["file"].append( dir_or_file )

    return dict_path


# Process `inp` with `ccx`
def ccx_process_inp(path):
    pass 

# Funcs Converter
def convert_frd_to_vtu(frd_path):
    c = Converter( str(frd_path), ["vtu"] )
    return c.run()

def convert_all_things():
    tree_of_dir = get_recursive_tree(input_dir)
    frd_files = []
    for f in tree_of_dir["file"]:
        if f.suffix == ".frd":
            frd_files.append(f)
    
    if len(frd_files) == 0:
        print("Nothing bro...")
        return
    
    for frd in frd_files:
        try:
            convert = convert_frd_to_vtu(frd)
            if convert:
                print(f"The file `{frd}` is converted.")
                name = frd.name.replace(".frd", ".vtu")
                directory = frd.parent
                vtu_file = directory.jopinpath(name) 
                shutil.move(vtu_file, output_dir)
                print(f"Moving `{vtu_file}`, to `{output_dir}`")
        except:
            print(f"Error converting frd to vtu: `{frd}`")
print("# Converting files")
convert_all_things()