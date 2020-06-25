namespace BuilderPattern
{
    /// <summary>
    /// FurnitureItem class
    /// </summary>
    public class FurnitureItem
    {
        public string Name;

        public double Price;

        public double Height;

        public double Width;

        public double Weight;

        /// <summary>
        /// FurnitureItem constructor
        /// </summary>
        /// <param name="productName">furniture item's name value</param>
        /// <param name="price">furniture item's price value</param>
        /// <param name="height">furniture item's height value</param>
        /// <param name="width">furniture item's width value</param>
        /// <param name="weight">furniture item's weight value</param>
        public FurnitureItem(string productName, double price, double height, double width, double weight)
        {
            Name = productName;
            Price = price;
            Height = height;
            Width = width;
            Weight = weight;
        }
    }
}