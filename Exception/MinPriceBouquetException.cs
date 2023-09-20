namespace FlowerShopProject.Exception
{
    public class MinPriceBouquetException : IOException
    {
        public MinPriceBouquetException() : base($"Prise of the bouquet can't be less than 10")
        {
        }
    }
}