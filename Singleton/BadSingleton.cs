using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class BadSingleton
    {
        private BadSingleton()
        {
        }

        public static BadSingleton CreateInstance()
        {
            return new BadSingleton();
        }
        public void DoSomething()
        {

        }
    }
}
