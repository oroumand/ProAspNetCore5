using System.Collections.Generic;

namespace Refactoring.Logic.V03
{
    public class FileContent
    {
        public readonly string FileName;
        public readonly List<string> Lines;
        public FileContent(string fileName, List<string> lines)
        {
            FileName = fileName;
            Lines = lines;
        }
    }
}
