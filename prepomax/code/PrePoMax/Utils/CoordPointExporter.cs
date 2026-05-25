using CaeMesh;
using System.Collections.Generic;
using System.IO;

namespace PrePoMax.Utils
{
    internal class CoordPointExporter
    {
        public static bool ExportXYZ(CoordPointSet pointSet, string fileName)
        /*
        Formato:
        # CSV file produced by FreeCAD
        # order;activity;x-coordinate;y-coordinate;z-coordinate;x-orientation;y-orientation;z-orientation
        1;true;0.5044234;-0.2982667;0.003258564;0.0;0.0;0.001
        2;true;0.5044234;-0.3391758;0.04416765;0.0;0.0;0.001
        */
        {
            List<string> lines = new List<string>();

            foreach (CoordPoint point in pointSet.Points)
            {
                lines.Add( 
                    $"{point.Id};{point.X};{point.Y};{point.Z}" 
                );
            }
            File.WriteAllLines(fileName, lines);
            
            return true;
        }
    }
}
