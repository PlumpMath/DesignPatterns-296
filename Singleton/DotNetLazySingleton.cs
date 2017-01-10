using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //.Net Lazy Singleton Implementation
    public class DotNetLazySingleton
    {
        private static readonly Lazy<DotNetLazySingleton> _instance = new Lazy<DotNetLazySingleton>(() => new DotNetLazySingleton(), true);
        private DotNetLazySingleton(){
            Console.WriteLine("Singleton Constructor");
        }

        public static DotNetLazySingleton Instance {get{return _instance.Value;}}
        public static void SayHi(){
            Console.WriteLine("Hi There");
        }
    }
}
