using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using Xunit;

namespace SingletonTests
{
    public class InefficientSingletonTest
    {
        [Fact]
        public void PassingTest()
        {
            //Arrange
            var s1 = InefficientSingleton.Instance;
            var s2 = InefficientSingleton.Instance;
            //Act
            //Assert
            Assert.Same(s1,s2);
        }
    }
}
