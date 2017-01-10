using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LazySingleton
    {
        private static readonly LazySingleton _instance = new LazySingleton();
        //Empty Static Constructor
        LazySingleton() { }

        public static LazySingleton Instance => _instance;
    }
}
