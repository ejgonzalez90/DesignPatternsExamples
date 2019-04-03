using System;

namespace DesignPatternsExamples.Singleton
{
    // Lazy Loading
    //  Improves performance
    //  Avoids unnecessary load untill the point object is accessed
    //  Reduces memory footprint on the start-up
    //  Faster application load

    public class LazySingletonClass
    {
        private LazySingletonClass()
        {            
        }

        private static Lazy<LazySingletonClass> _instance = new Lazy<LazySingletonClass>();

        public static LazySingletonClass GetLazySingletonInstance
        {
            get
            {
                // You can access the instance using the .value property of Lazy
                return _instance.Value;
            }
        }
    }
}