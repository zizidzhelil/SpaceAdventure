using System.Data;

namespace SpaceAdventure.Writers
{
    public interface ITextFileWriter
    {
        void Write(DataTable reportData, string filePathFull);
    }
}
