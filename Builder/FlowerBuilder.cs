using FlowerShopProject.Domain;
using FlowerShopProject.Exception;

namespace FlowerShopProject.Builder
{
    public class FlowerBuilder : IFlowerBuilder
    {
        //Build flower depending on the size from the bud
        public Flower BuildFlower(string name, decimal price, string color, string size = "Medium")
        {
            Flower flower = new()
            {
                Name = name,
                Color = color,
                Size = size
            };

            if (price >= 0)
            {

                switch (size)
                {
                    case "Small":
                        flower.Price = price * 0.9m;
                        break;
                    case "Medium":
                        flower.Price = price;
                        break;
                    case "Big":
                        flower.Price = price * 1.1m;
                        break;
                    default:
                        flower.Price = price;
                        break;
                }
            }

            else
                throw new MinPriceFlowerException(price, 1);

            return flower;
        }
    }
}