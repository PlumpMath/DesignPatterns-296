using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SimpleSingleton
    {
        //This is now thread safe because It is a static initaliser and so .Net CLR only allows 1 thread
        //to initalise. Therefore it is a singleton.
        private static readonly SimpleSingleton _instance = new SimpleSingleton();

        public static SimpleSingleton Instance => _instance;

        private SimpleSingleton()
        {
            Console.WriteLine("Simple Singleton Constructor");
        }
    }
}
