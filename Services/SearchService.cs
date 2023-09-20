using FlowerShopProject.Builder;
using FlowerShopProject.Domain;

namespace FlowerShopProject.Services
{
    //Search flower by parameter (Name, Price or Color)
    public class SearchService
    {
        public static List<Flower>? SearchFlower(string parameter)
        {
            List<Flower>? searchingFlower = new();

            foreach (KeyValuePair<Flower, int> bouquet in new BouquetBuilder().BuildFlowers())
            {
                try
                {
                    if (bouquet.Key.Name.ToLower().Contains(parameter))
                        searchingFlower.Add(bouquet.Key);
                    else if (bouquet.Key.Color.ToLower().Contains(parameter))
                        searchingFlower.Add(bouquet.Key);
                    else if ((double.TryParse(parameter, out _)) && bouquet.Key.Price.Equals(Convert.ToDecimal(parameter)))
                        searchingFlower.Add(bouquet.Key);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex);
                }
            }

            return searchingFlower;
        }

        // Enter parameter from Console for searching flower
        public static string EnterDataForSearching()
        {
            Console.WriteLine("Enter parameter of searching flower:");
            string? parameter;

            do
            {
                parameter = Console.ReadLine();
            } while (string.IsNullOrEmpty(parameter));
            return parameter;
        }

        //Output of the search result
        public static void ShowResultOfSearching(string parameter)
        {
            List<Flower>? searchingFlowers = new();

            try
            {
                searchingFlowers = SearchFlower(parameter.ToLower());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"One of your parameters isn't found - {ex}");
            }

            if (searchingFlowers.Count == 0)
            {
                Console.WriteLine("Searching flower is not found!");
            }
            else
            {
                foreach (var flower in searchingFlowers)
                {
                    Console.WriteLine($"Your flower is {flower}");
                }
            }
        }
    }
}