using DesignPatterns.Singleton;

var singleton = Singleton.Instance;

var log = Log.Instance;
var log2 = Log.Instance;

Console.WriteLine(log == log2);
Console.ReadLine();
