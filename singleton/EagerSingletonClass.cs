namespace DesignPatternsExamples.Singleton
{
    // Eager loading
    //  Pre-instantiation of the object
    //  Commonly used in lower memory footprints

    // In this case the .NET runtime is the one responsible for instatiating _instance, and this is
    // provided in a thread safe manner
    public sealed class EagerSingletonClass
    {
        private EagerSingletonClass()
        {            
        }

        // To make this singleton with Eager loading, we need to instantiate the _instance in the declaration
        private static readonly EagerSingletonClass _instance = new EagerSingletonClass();

        public static EagerSingletonClass GetEagerSingletonClassInstance
        {
            get
            {
                // In order to avoid setting _instance as a new instance of the EagerSingletonClass we've set it readonly
                // _instance = new EagerSingletonClass();

                return _instance;
            }
        }
    }
}