namespace FlowerShopProject.Exception
{
    public class MinPriceFlowerException : IOException
    {
        public decimal value;

        public MinPriceFlowerException(decimal value, int minValue) : base($"Prise of the flower can't be less than {minValue}. Yoy enter {value}")
        {
            this.value = value;
        }
    }
}