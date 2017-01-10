using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //This class now does not have a constructor till the Instance variable is used. Only then the Singleton is initalised.
    //When SayHi is called, the class singleton is not initialised as it is in the "LazySingleton" class.
    public class FullyLazySingleton
    {
        private static class FullyLazySingletonHolder
        {
            internal static readonly FullyLazySingleton _instance = new FullyLazySingleton();
            static FullyLazySingletonHolder(){}
        }

        private FullyLazySingleton(){
            Console.WriteLine("Singleton Constructor");
        }

        public static FullyLazySingleton Instance {get{return FullyLazySingletonHolder._instance;}}
        public static void SayHi(){
            Console.WriteLine("Hi There");
        }
    }
}
