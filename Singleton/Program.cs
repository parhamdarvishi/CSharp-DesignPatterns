// call the property getter twice
using Singleton;

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances (Not Thread Safe) are the same.");
}
Console.WriteLine("***************************************");

var instance3 = Logger_ThreadSafe.Instance;
var instance4 = Logger_ThreadSafe.Instance;

if (instance3 == instance4 && instance3 == Logger_ThreadSafe.Instance)
{
    Console.WriteLine("Instances (Thread Safe) are the same.");
}