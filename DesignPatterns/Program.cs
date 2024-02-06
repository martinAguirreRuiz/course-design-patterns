//using DesignPatterns.Singleton;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Models;
using DesignPatterns.Repository;
using DesignPatterns.Strategy;
using DesignPatterns.UnitOfWork;
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

        //using (var context = new BeerContext())
        //{
        //    var beerRepository = new Repository<Beer>(context);
        //    var brandRepository = new Repository<Brand>(context);

        //    var brand = new Brand() { Name = "Marca-X" };

        //    beerRepository.Delete(3);
        //    beerRepository.Save();

        //    brandRepository.Add(brand);
        //    brandRepository.Save();


        //}

        //-----------------------------------------------------------------

        // UNIT OF WORK

        //using (var context = new BeerContext())
        //{
        //    var unitOfWork = new UnitOfWork(context);

        //    var beers = unitOfWork.Beers;
        //    var beer = new Beer
        //    {
        //        Name = "Test",
        //        Style = "Marca-Test"
        //    };

        //    beers.Add(beer);

        //    var brands = unitOfWork.Brands;
        //    var brand = new Brand
        //    {
        //        Name = "Test-Brand",
        //    };

        //    brands.Add(brand);

        //    unitOfWork.Save();
        //}

        //-----------------------------------------------------------------

        // STRATEGY

        //var context = new Context(new CarStrategy());
        //context.Run();
        //context.Strategy = new MotoStrategy();
        //context.Run();
        //context.Strategy = new BikeStrategy();
        //context.Run();

        //-----------------------------------------------------------------

        // BUILDER

        var alcoholDrinkBuilder = new PreparedAlcoholDrinkConcreteBuilder();
        var barmanDirector = new BarmanDirector(alcoholDrinkBuilder);

        barmanDirector.PrepareMargarita();

        var preparedDrink = alcoholDrinkBuilder.GetPreparedDrink();
        Console.WriteLine(preparedDrink.Result);
    }
}