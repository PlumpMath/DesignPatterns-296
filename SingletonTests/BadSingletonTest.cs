using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SingletonTests
{
    public class BadSingletonTest
    {
        [Fact]
        public void PassingTest()
        {
            //Arrange
            var s1 = BadSingleton.Instance;
            var s2 = BadSingleton.Instance;
            //Act

            //Assert
            Assert.Same(s1, s2);
        }
    }
}
