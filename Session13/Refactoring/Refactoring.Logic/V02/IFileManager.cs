using System.Collections.Generic;

namespace Refactoring.Logic.V02
{
    public interface IFileManager
    {
        List<string> GetFiles(string directoryName);
        void WriteAllText(string filePath, string content);
        void WriteAllLines(string filePath, List<string> content);
        List<string> ReadAllLines(string filePath);
    }
}
