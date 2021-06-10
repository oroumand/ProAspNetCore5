using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Refactoring.Logic.V02
{

    public class AuditManager
    {
        private readonly int _maxEntryPerFile;
        private readonly string _directoryName;
        private readonly IFileManager _fileManager;

        public AuditManager(int maxEntryPerFile, string directoryName, IFileManager fileManager)
        {
            _maxEntryPerFile = maxEntryPerFile;
            _directoryName = directoryName;
            _fileManager = fileManager;
        }
        public void AddLog(string customerName, DateTime dateTime)
        {
            var filePaths = _fileManager.GetFiles(_directoryName).OrderBy(c => c).ToList();
            var entry = $"{customerName}; {dateTime}";
            if (filePaths.Count < 1)
            {
                string newFile = Path.Combine(_directoryName, "Audit1.txt");
                _fileManager.WriteAllText(newFile, entry);
                return;
            }

            var curentFileContent = _fileManager.ReadAllLines(filePaths.Last()).ToList();
            if (curentFileContent.Count() < _maxEntryPerFile)
            {
                curentFileContent.Add(entry);
                _fileManager.WriteAllLines(filePaths.Last(), curentFileContent);
            }
            else
            {
                string newFileName = $"Audit{filePaths.Count + 1}.txt";
                string newFile = Path.Combine(_directoryName, newFileName);
                _fileManager.WriteAllText(newFile, entry);
            }


        }
    }
}
