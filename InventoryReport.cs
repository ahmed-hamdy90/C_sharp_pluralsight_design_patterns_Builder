using System.Text;

namespace BuilderPattern
{
    /// <summary>
    /// InventoryReport class
    /// </summary>
    public class InventoryReport
    {
        public string TitleSection;

        public string DimensionsSection;

        public string LogisticsSection;

        public string Debug()
        {
            return new StringBuilder()
                .AppendLine(TitleSection)
                .AppendLine(DimensionsSection)
                .AppendLine(LogisticsSection)
                .ToString();
        }
    }
}