using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CaeGlobals;

namespace CaeMesh
{
    [Serializable]
    public class CoordPointSet : FeGroup 
    {
        // Variables
        private List<CoordPoint> _points;
        private int _maxPointId;

        // Constructors
        public CoordPointSet(string name) 
            : base(name, new int[0])
        {
            _points = new List<CoordPoint>();
        }

        // Methods
        public List<CoordPoint> Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public void AddPoint(double x, double y, double z)
        {
            _maxPointId++;
            
            _points.Add(
                new CoordPoint(_maxPointId, x, y, z)
            );
        }
    }
}
