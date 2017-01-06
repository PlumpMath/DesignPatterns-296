using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SingletonTests
{
    public class SimpleSingletonTest
    {
        [Fact]
        public void UoW_InitialCondition_ExpectedResult()
        {
            //Arrange
            var s1 = SimpleSingleton.Instance;
            var s2 = SimpleSingleton.Instance;
            //Act


            //Assert
            Assert.Same(s1, s2);
        }
    }
}
