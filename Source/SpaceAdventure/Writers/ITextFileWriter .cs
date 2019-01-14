using System.Data;

namespace SpaceAdventure.Writers
{
    public interface ITextFileWriter
    {
        void Write(string filePathFull, DataTable reportData);
    }
}
