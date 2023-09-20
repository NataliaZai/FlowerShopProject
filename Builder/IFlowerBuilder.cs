using FlowerShopProject.Domain;

namespace FlowerShopProject.Builder
{
    public interface IFlowerBuilder
    {
        public Flower BuildFlower(string name, decimal price, string color, string size);
    }
}