using System;
using System.IO;

namespace PrePoMax.Utils
{
    internal class ResourceLoader
    {
        private readonly string _baseDir;

        public string BaseDir
        {
            get { return _baseDir; }
        }

        public ResourceLoader()
        {
            _baseDir = AppDomain.CurrentDomain.BaseDirectory;
        }

        public bool ExistsPath(string path)
        {
            return
                File.Exists(path) ||
                Directory.Exists(path);
        }
    }
}
