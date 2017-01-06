using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonClient
    {
        public void UseSingleton()
        {
            var s1 = BadSingleton.Instance;
        }
    }
}
