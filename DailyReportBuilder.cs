using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern
{
    /// <summary>
    /// DailyReportBuilder represent builder instance for daily inventory report
    /// </summary>
    public class DailyReportBuilder : IFurnitureInventoryBuilder
    {
        private InventoryReport _report;
        private readonly IEnumerable<FurnitureItem> _items;

        /// <summary>
        /// DailyReportBuilder constructor
        /// </summary>
        /// <param name="items">furniture items will daily report be about them</param>
        public DailyReportBuilder(IEnumerable<FurnitureItem> items)
        {
            Reset();
            _items = items;
        }

        /// <inheritdoc cref="IFurnitureInventoryBuilder.AddTitle"/>
        public IFurnitureInventoryBuilder AddTitle()
        {
            _report.TitleSection = "------ Daily Inventory Report ------\n\n";
            
            return this;
        }

        /// <inheritdoc cref="IFurnitureInventoryBuilder.AddDimensions"/>
        public IFurnitureInventoryBuilder AddDimensions()
        {
            IEnumerable<string> itemsInfo = _items.Select(product =>
            {
                return $"Product: {product.Name} \nPrice: {product.Price} \n" +
                       $"Height: {product.Height} * Width: {product.Weight} -> Weight: {product.Weight} lbs\n";
            });
            _report.DimensionsSection = string.Join(Environment.NewLine, itemsInfo);

            return this;
        }

        /// <inheritdoc cref="IFurnitureInventoryBuilder.AddLogistics"/>
        public IFurnitureInventoryBuilder AddLogistics(DateTime dateTime)
        {
            _report.LogisticsSection = $"Report Generated on {dateTime}";

            return this;
        }

        /// <inheritdoc cref="IFurnitureInventoryBuilder.GetDailyReport"/>
        public InventoryReport GetDailyReport()
        {
            // save complete inventory report instance into temp member then call Rest method 
            InventoryReport finishedReport = _report;
            Reset();

            return finishedReport;
        }

        /// <summary>
        /// Reset inventory report instance
        /// </summary>
        public void Reset()
        {
            _report = new InventoryReport();
        }
    }
}