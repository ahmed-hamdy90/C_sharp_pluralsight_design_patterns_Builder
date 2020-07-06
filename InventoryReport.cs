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

        /// <summary>
        /// Debug method which help us in return report result with console 
        /// </summary>
        /// <returns>string builder instance include report result</returns>
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