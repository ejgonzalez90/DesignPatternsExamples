using System;
using System.Threading.Tasks;
using DesignPatternsExamples.Singleton;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // The GetSingletonClassInstance method puts in console the current count for SingletonClass's instances
            // var _firstSingletonObject = SingletonClass.GetSingletonClassInstance();
            // var _secondSingletonObject = SingletonClass.GetSingletonClassInstance();
            
            // This is why singleton class must be sealed, check SingletonClass's definition
            // var _subClassSingletonObject = new SingletonClass.SingletonSubClass();
            // SingletonClass.GetSingletonClassInstance();
            
            // If the singleton pattern it's well written, there sould alwas be one instance of it

            // Pause
            // Console.ReadLine();

            // Use debugger with an stop in the IF line of the GetSingletonClassInstance mehtod
            Task.Run(() => SingletonClass.GetSingletonClassInstance);
            Task.Run(() => SingletonClass.GetSingletonClassInstance);

            // Pause! :)
            Console.ReadLine();
        }
    }
}
