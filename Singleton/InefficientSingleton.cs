using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class InefficientSingleton
    {
        private static readonly object Mutex = new object();
        private static InefficientSingleton _instance;

        public static InefficientSingleton Instance
        {
            get
            {
                lock (Mutex)
                {
                    return _instance ?? (_instance = new InefficientSingleton());
                }
            }
        }
    }
}
