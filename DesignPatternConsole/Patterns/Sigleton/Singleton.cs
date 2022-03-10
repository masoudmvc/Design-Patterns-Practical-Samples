namespace DesignPatternConsole.Patterns.Sigleton
{
    //https://www.dofactory.com/net/singleton-design-pattern
    
    //Run Command:
    //var s1 = Singleton.GetInstance();
    //s1.Value = 10;
    //var s2 = Singleton.GetInstance();
    //Console.WriteLine(s2.Value);
    public class Singleton
    {
        static Singleton? _inctance;

        private static object locker = new();

        protected Singleton()
        {

        }

        public int Value { get; set; }

        public static Singleton GetInstance()
        {
            if (_inctance == null)
            {
                // Support multithreaded applications
                lock (locker)
                {
                    if (_inctance == null) 
                        _inctance = new Singleton();
                }
            }

            return _inctance;
        }
    }


}
