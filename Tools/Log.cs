using System.Runtime.InteropServices;

namespace Tools
{
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;
        public static Log Instance {  get { return _instance; } }
        public Log(string path)
        {
            _path = path;
        }
        public static Log GetInstance(string path)
        {
            if (_instance == null)
            {
                _instance = new Log(path);
            }
            return _instance;
        }
        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}
