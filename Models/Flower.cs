namespace FlowerShopProject.Domain
{
    public class Flower
    {
        public string? Name { set; get; }

        public string? Color { set; get; }

        public string? Size { set; get; }

        public decimal Price { set; get; }


        public override string? ToString()
        {
            return Name;
        }
    }
}