using FlowerShopProject.Domain;
using FlowerShopProject.Enums;
using FlowerShopProject.Exception;

namespace FlowerShopProject.Builder
{
    //Build our bouquet
    public class BouquetBuilder : IBouquetBuilder
    {
        public Dictionary<Flower, int> BuildFlowers()
        {
            FlowerBuilder flowerBuilder = new();

            return new Dictionary<Flower, int>()
            {
                {
                    flowerBuilder.BuildFlower(FlowerName.Tulip.ToString(), 12.5m, Color.Red.ToString()), 3
                },
                {
                    flowerBuilder.BuildFlower(FlowerName.Chamomile.ToString(), 11.5m, Color.White.ToString()), 5
                },
                {
                    flowerBuilder.BuildFlower(FlowerName.Rose.ToString(), 10, Color.Red.ToString(), FlowerBudSize.Small.ToString()), 5
                },
                {
                    flowerBuilder.BuildFlower(FlowerName.Gerbera.ToString(), 11.5m, Color.Yellow.ToString()), 6
                },
            };
        }

        //Determine price of the bouquet
        public decimal BuildPriceOfBouquet(Dictionary<Flower, int> setOfFlowers)
        {
            decimal priceOfBouquet = 0;

            try
            {
                foreach (KeyValuePair<Flower, int> flowers in setOfFlowers)
                {
                    if (flowers.Value <= 0)
                    {
                        throw new MinNumberOfFlowersException();
                    }

                    priceOfBouquet += flowers.Key.Price * flowers.Value;
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Your bouquet is empty!");
            }

            if (priceOfBouquet <= 10)
            {
                throw new MinPriceBouquetException();
            }
            return priceOfBouquet;

        }

        //Create some packaging
        public string BuildPackaging()
        {
            return "Without packaging";
        }

        public Bouquet GetBouquet()
        {
            Bouquet bouquet = new();
            try
            {

                bouquet.Flowers = BuildFlowers();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Flower can't be null - {ex}");
            }

            try
            {
                bouquet.PriceOfBouquet = BuildPriceOfBouquet(bouquet.Flowers);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You can't calculate price of empty bouquet");
            }
            bouquet.Packaging = BuildPackaging();
            return bouquet;
        }
    }
}