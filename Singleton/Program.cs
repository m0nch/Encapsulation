using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton 
            Singleton ob = Singleton.Instance;
            Singleton.Show(ob);

            Singleton ob2 = Singleton.Instance;
            Singleton.Show(ob2);

            Singleton ob3 = Singleton.Instance;
            Singleton.Show(ob3);

            Console.ReadKey();
        }
    }

    //Singleton example
    class Singleton
    {
        private static int counter = default(int);
        private static Singleton _instance;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine($"The constructor called {counter} time");
        }

        public static void Show(Singleton instance)
        {
            Console.WriteLine(instance.GetHashCode());
        }
    }
}
