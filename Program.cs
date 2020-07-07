using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    /// <summary>
    /// Main Program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Static Main method
        /// </summary>
        /// <param name="args">programs arguments list</param>
        static void Main(string[] args)
        {
            var items = new List<FurnitureItem>()
            {
                new FurnitureItem("Sectional Couch", 55.5, 22.4, 78.6, 35.0),
                new FurnitureItem("Nightstand", 25.0, 12.4, 20.0, 10.0),
                new FurnitureItem("Dining Table", 105.0, 35.4, 100.6, 55.5),
            };

            // create report Builder then build report
            // [Here how to apply Builder design pattern using Fluent builder like built-in StringBuilder class]
            DailyReportBuilder inventoryReportBuilder = new DailyReportBuilder(items);
            inventoryReportBuilder.AddTitle()
                .AddDimensions()
                .AddLogistics(DateTime.Now);

            InventoryReport inventoryReport = inventoryReportBuilder.GetDailyReport();

            Console.WriteLine(inventoryReport.Debug());
        }
    }
}