using System.IO;
using System.Data;

namespace SpaceAdventure.Writers.Implementation
{
    public class TextFileWriter : ITextFileWriter
    {
        public void Write(DataTable reportData, string filePathFull)
        {
            using (StreamWriter writer = new StreamWriter(filePathFull))
            {
                int i;
                foreach (DataRow row in reportData.Rows)
                {
                    object[] array = row.ItemArray;
                    for (i = 0; i < array.Length - 1; i++)
                    {
                        writer.Write(array[i].ToString() + ": ");
                    }
                    writer.WriteLine(array[i].ToString());
                }
            }
        }
    }
}
