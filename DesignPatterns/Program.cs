//using DesignPatterns.Singleton;
using DesignPatterns.Factory;
using DesignPatterns.Models;
using DesignPatterns.Repository;
public class Program
{
    public static void Main(string[] args)
    {
        // Código de inicio de la aplicación

        // SINGLETON


        //var singleton = Singleton.Instance;

        //var log = Log.Instance;
        //var log2 = Log.Instance;

        //Console.WriteLine(log == log2);
        //Console.ReadLine();

        //-----------------------------------------------------------------

        // FACTORY


        //SaleFactory storeSaleFactory = new StoreSaleFactory(5);
        //SaleFactory internetSaleFactory = new InternetSaleFactory(5);

        //ISale storeSale = storeSaleFactory.GetSale();
        //ISale internetSale = internetSaleFactory.GetSale();

        //storeSale.Sell(10);
        //internetSale.Sell(10);

        //-----------------------------------------------------------------

        // REPOSITORY

        //using (var context = new BeerContext())
        //{
        //    var beerRepository = new BeerRepository(context);

        //    var beer = new Beer();
        //    beer.Name = "Corona";
        //    beer.Style = "Marca-3";
        //    beerRepository.Add(beer);
        //    beerRepository.Save();

        //    foreach (var b in beerRepository.Get())
        //    {
        //        Console.Write(b.Name);
        //    }
        //}

        using (var context = new BeerContext())
        {
            var beerRepository = new Repository<Beer>(context);
            var brandRepository = new Repository<Brand>(context);

            var brand = new Brand() { Name = "Marca-X" };

            beerRepository.Delete(3);
            beerRepository.Save();

            brandRepository.Add(brand);
            brandRepository.Save();


        }

    }
}