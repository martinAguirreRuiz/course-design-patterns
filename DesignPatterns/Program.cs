
// SINGLETON

//using DesignPatterns.Singleton;

//var singleton = Singleton.Instance;

//var log = Log.Instance;
//var log2 = Log.Instance;

//Console.WriteLine(log == log2);
//Console.ReadLine();

//-----------------------------------------------------------------

// FACTORY

using DesignPatterns.Factory;

SaleFactory storeSaleFactory = new StoreSaleFactory(5);
SaleFactory internetSaleFactory = new InternetSaleFactory(5);

ISale storeSale = storeSaleFactory.GetSale();
ISale internetSale = internetSaleFactory.GetSale();

storeSale.Sell(10);
internetSale.Sell(10);
