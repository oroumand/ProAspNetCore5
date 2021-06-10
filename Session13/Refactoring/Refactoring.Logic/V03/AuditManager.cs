using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Refactoring.Logic.V03
{
    public class ApplicationService
    {
        private readonly string _directoryName;
        private readonly AuditManager _auditManager;
        private readonly FileManager _fileManager;


        public ApplicationService(string directoryName, int maxEntriesPerFile)
        {
            _directoryName = directoryName;
            _auditManager = new AuditManager(maxEntriesPerFile);
            _fileManager = new FileManager();
        }
        public void AddRecord(string customerName, DateTime dateTime)
        {
            var files = _fileManager.ReadDirectory(_directoryName);
            FileUpdate update = _auditManager.AddLog(customerName, dateTime, files);
            _fileManager.ApplyUpdate(_directoryName, update);
        }
    }


    public class AuditManager
    {
        private readonly int _maxEntryPerFile;

        public AuditManager(int maxEntryPerFile)
        {
            _maxEntryPerFile = maxEntryPerFile;
        }
        public FileUpdate AddLog(string customerName, DateTime dateTime, List<FileContent> fileContents)
        {
            var sortedfile = fileContents.OrderBy(c => c.FileName).ToList();
            var entry = $"{customerName}; {dateTime}";

            if (sortedfile.Count == 0)
            {
                return new FileUpdate("Audit1.txt", entry);
            }

            List<string> lines = sortedfile.Last().Lines;

            if (lines.Count < _maxEntryPerFile)
            {
                lines.Add(entry);
                string newContent = string.Join("\r\n", lines);
                return new FileUpdate(sortedfile.Last().FileName, newContent);
            }
            string newName = $"audit{sortedfile.Count + 1}.txt";
            return new FileUpdate(newName, entry);
        }
    }
}
