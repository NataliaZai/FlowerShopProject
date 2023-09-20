namespace FlowerShopProject.Domain
{
    public class Bouquet
    {
        public Dictionary<Flower, int>? Flowers { get; set; }

        public string? Packaging { get; set; }

        public decimal PriceOfBouquet { get; set; }

        public override string ToString()
        {
            return string.Format($"Your bouquet costs {PriceOfBouquet} and has this type of packaging - {Packaging}");
        }
    }
}