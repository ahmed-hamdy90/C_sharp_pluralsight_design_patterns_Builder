using System;

namespace BuilderPattern
{
    /// <summary>
    /// IFurnitureInventoryBuilder represent main builder interface for any furniture inventory report
    /// </summary>
    public interface IFurnitureInventoryBuilder
    {
        /// <summary>
        /// Adding title section details of report
        /// </summary>
        /// <returns>return current instance of builder</returns>
        IFurnitureInventoryBuilder AddTitle();

        /// <summary>
        /// Adding dimensions section details of report
        /// </summary>
        /// <returns>return current instance of builder</returns>
        IFurnitureInventoryBuilder AddDimensions();

        /// <summary>
        /// Adding logistics section details of report
        /// </summary>
        /// <param name="dateTime">datetime instance need into setting logistics info</param>
        /// <returns>return current instance of builder</returns>
        IFurnitureInventoryBuilder AddLogistics(DateTime dateTime);

        /// <summary>
        /// Getting report instance
        /// </summary>
        /// <returns>full report instance</returns>
        InventoryReport GetDailyReport();
    }
}