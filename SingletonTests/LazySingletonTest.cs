using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Singleton;

namespace SingletonTests
{
    public class LazySingletonTest
    {
        [Fact]
        public void UoW_IsTrue_True()
        {
            //Arrange
            var s1 = LazySingleton.Instance;
            var s2 = LazySingleton.Instance;
            //Act


            //Assert
            Assert.Same(s1, s2);

        }
    }
}
