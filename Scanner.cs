using System.IO;

namespace GFN
{
    class Scanner
    {
        public string Scan(string file)
        {
            return File.ReadAllText(file);
        }
    }
}
