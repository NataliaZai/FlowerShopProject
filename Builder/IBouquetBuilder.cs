using FlowerShopProject.Domain;

namespace FlowerShopProject.Builder
{
    public interface IBouquetBuilder
    {
        public Dictionary<Flower, int> BuildFlowers();

        public string BuildPackaging();

        public decimal BuildPriceOfBouquet(Dictionary<Flower, int> flowers);

        Bouquet GetBouquet();
    }
}