namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// A protected constructor is defined for the singleton pattern in C# to prevent other classes from instantiating the singleton class. 
        /// By making the constructor protected, it can only be accessed by the class itself or derived classes. This ensures that only one instance of the class can be created and the singleton pattern is maintained. 
        /// Additionally, this allows for greater control over how and when the class is instantiated, which can be useful in certain situations.
        /// </summary>
        protected Logger()
        {
        }

        private static Logger? _instance;

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        /// <summary>
        /// Singleton Operation
        /// </summary> 
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }

    }
}
