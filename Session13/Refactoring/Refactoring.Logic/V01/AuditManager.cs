using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Refactoring.Logic.V01
{
    public class AuditManager
    {
        private readonly int _maxEntryPerFile;
        private readonly string _directoryName;

        public AuditManager(int maxEntryPerFile, string directoryName)
        {
            _maxEntryPerFile = maxEntryPerFile;
            _directoryName = directoryName;
        }
        public void AddLog(string customerName, DateTime dateTime)
        {
            var filePaths = Directory.GetFiles(_directoryName).OrderBy(c => c).ToList();
            var entry = $"{customerName}; {dateTime}";
            if (filePaths.Count < 1)
            {
                string newFile = Path.Combine(_directoryName, "Audit1.txt");
                File.WriteAllText(newFile, entry);
                return;
            }

            var curentFileContent = File.ReadAllLines(filePaths.Last()).ToList();
            if(curentFileContent.Count() < _maxEntryPerFile)
            {
                curentFileContent.Add(entry);
                File.WriteAllLines(filePaths.Last(), curentFileContent);
            }
            else
            {
                string newFileName = $"Audit{filePaths.Count + 1}.txt";
                string newFile = Path.Combine(_directoryName, newFileName);
                File.WriteAllText(newFile, entry);
            }


        }
    }
}
