using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class BadSingleton
    {
        //variable isnt readonly?
        private static BadSingleton _instance;
        //not threadsafe because multiple threads can access this code at exactly the same time.
        public static BadSingleton Instance
        {
            get { return _instance ?? (_instance = new BadSingleton()); }
        }

        public void DoSomething()
        {

        }
    }
}
