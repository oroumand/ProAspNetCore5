namespace Refactoring.Logic.V03
{
    public class FileUpdate
    {
        public readonly string FileName;
        public readonly string NewContent;
        public FileUpdate(string fileName, string newContent)
        {
            FileName = fileName;
            NewContent = newContent;
        }
    }
}
