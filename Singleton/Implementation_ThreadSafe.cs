namespace Singleton
{
    /// <summary>
    /// Singleton (Thread Safe)
    /// </summary>
    public class Logger_ThreadSafe
    {
        /// <summary>
        /// A protected constructor is defined for the singleton pattern in C# to prevent other classes from instantiating the singleton class. 
        /// By making the constructor protected, it can only be accessed by the class itself or derived classes. This ensures that only one instance of the class can be created and the singleton pattern is maintained. 
        /// Additionally, this allows for greater control over how and when the class is instantiated, which can be useful in certain situations.
        /// </summary>
        protected Logger_ThreadSafe()
        {

        }

        /// <summary>
        /// Lazy<T> is a type in C# that allows for lazy initialization of an object. This means that the object is not created until it is actually needed, rather than being created as soon as the program starts. 
        /// This can be useful in situations where the object is only used in certain parts of the code and creating it immediately would be unnecessary and could cause performance issues.
        /// </summary>
        private static readonly Lazy<Logger_ThreadSafe> _lazyLogger
           = new Lazy<Logger_ThreadSafe>(() => new Logger_ThreadSafe());

        public static Logger_ThreadSafe Instance
        {
            get { return _lazyLogger.Value; }
        }

        /// <summary>
        /// SingletonOperation
        /// </summary> 
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
