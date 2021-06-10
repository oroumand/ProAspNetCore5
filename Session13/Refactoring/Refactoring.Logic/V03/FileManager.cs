using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Refactoring.Logic.V03
{
    public class FileManager
    {
        public List<FileContent> ReadDirectory(string directoryName)
        {
            return Directory.GetFiles(directoryName).Select(c => new FileContent(Path.GetFileName(c), File.ReadAllLines(c).ToList())).ToList();
        }
        public void ApplyUpdate(string directoryName, FileUpdate update)
        {
            string filePath = Path.Combine(directoryName, update.FileName);
            File.WriteAllText(filePath, update.NewContent);
        }
    }
}
