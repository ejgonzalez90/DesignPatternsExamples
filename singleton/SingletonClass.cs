using System;

namespace DesignPatternsExamples.Singleton
{
    // Singleton Example
    // Singleton class should always be sealed, so it can't be inherited and it's constructor replaced
    public sealed class SingletonClass
    {
        // Singleton constructor should always be private, you don't want that clients of this class are able to call it
        private SingletonClass()
        {
            _instanceCounter ++;
        }

        // The basic idea of singleton pattern is having a private static variable, containing the instance of the singleton
        private static SingletonClass _singletonInstance;
        
        // This variable it's just used to count the number of instances through the demo
        private static int _instanceCounter { get; set; } = 0;

        // This object is just used for you to control the block of different threads accessing the GetSingletonClassInstance() method 
        private static object _threadBlocker = new object();

        // And a property with a getter that checks if that static instance is instantiated or not, and return it
        public static SingletonClass GetSingletonClassInstance
        {
            get
            {
                // Before making a block on the _threadBlocker object, is convinient to double check if the instance is created before 
                if (_singletonInstance == null)
                {
                    // double-checked locking (also known as "double-checked locking optimization"[1]) is a software design pattern used to reduce the overhead of acquiring a lock by testing the locking criterion
                    // https://en.wikipedia.org/wiki/Double-checked_locking
                    lock (_threadBlocker)
                    {
                        if (_singletonInstance == null)
                            _singletonInstance = new SingletonClass();    
                    }
                }
                
                Console.WriteLine($"SingletonClass's instance count: {_instanceCounter}");

                return _singletonInstance;
            }            
        }

        // This makes visible that nested classes that extend your singleton class can call it's private constructor
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/nested-types
        // public class SingletonSubClass : SingletonClass
        // {

        // }
    }
}