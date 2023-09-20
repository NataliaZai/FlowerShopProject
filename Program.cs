using FlowerShopProject.Builder;
using FlowerShopProject.Domain;
using FlowerShopProject.Services;


//Make bouquet

var builder = new BouquetBuilder();
Bouquet bouquet = builder.GetBouquet();
Console.WriteLine(bouquet);

//Search some flowers by parameter

string searchParameter = SearchService.EnterDataForSearching();

SearchService.ShowResultOfSearching(searchParameter);