using System;

namespace BuilderPattern
{
    /// <summary>
    /// InventoryBuildDirector represent Director class for any Inventory report Builder
    /// </summary>
    public class InventoryBuildDirector
    {
        private readonly IFurnitureInventoryBuilder _builder;

        /// <summary>
        /// InventoryBuildDirector constructor
        /// </summary>
        /// <param name="concreteBuilder">concrete builder instance for director class</param>
        public InventoryBuildDirector(IFurnitureInventoryBuilder concreteBuilder)
        {
            _builder = concreteBuilder;
        }

        /// <summary>
        /// Complete building report
        /// </summary>
        public void BuildCompleteReport()
        {
            _builder.AddTitle();
            _builder.AddDimensions();
            _builder.AddLogistics(DateTime.Now);
        }
    }
}