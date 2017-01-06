using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SimpleSingleton
    {
        private static readonly SimpleSingleton _instance = new SimpleSingleton();

        public static SimpleSingleton Instance => _instance;
    }
}
