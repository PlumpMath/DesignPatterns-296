using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Singleton;

namespace SingletonTests
{
    public class FullyLazySingletonTest
    {
        [Fact]
        public void UoW_IsTrue_True()
        {
            //Arrange
            var s1 = FullyLazySingleton.Instance;
            var s2 = FullyLazySingleton.Instance;
            //Act

            //Assert
            Assert.Same(s1, s2);

        }
    }
}
