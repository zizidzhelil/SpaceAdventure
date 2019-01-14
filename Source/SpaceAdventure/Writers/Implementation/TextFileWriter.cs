using System.Data;
using System.IO.Abstractions;
using System.Text;

namespace SpaceAdventure.Writers.Implementation
{
    public class TextFileWriter : ITextFileWriter
    {
        private readonly IFileSystem _fileSystem;

        public TextFileWriter(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void Write(string filePathFull, DataTable reportData)
        {
            StringBuilder reportBuilder = new StringBuilder();

            foreach (DataRow row in reportData.Rows)
            {
                int i;
                object[] array = row.ItemArray;

                for (i = 0; i < array.Length - 1; i++)
                {
                    reportBuilder.Append(array[i].ToString() + ": ");
                }

                reportBuilder.AppendLine(array[i].ToString());
            }

            _fileSystem.File.WriteAllText(filePathFull, reportBuilder.ToString());
        }
    }
}
