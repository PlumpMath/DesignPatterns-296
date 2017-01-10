using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SingletonTests
{
    public class BadDurationTest
    {
        [Fact]
        public void BadDuration_TicksAndMilliseconds_AreEqual()
        {
            //Arrange
            var factory = new BadDurationFactory();
            //Act
            var ticks = factory.FromTicks(10000);
            var milliseconds = factory.FromMilliseconds(1);

            //Assert
            Assert.Equal(ticks.Ticks, milliseconds.Ticks);
        }

        [Fact]
        public void BadDuration_TicksAndMilliseconds_AreNotEqual()
        {
            //Arrange
            var factory = new BadDurationFactory();
            //Act
            var ticks = factory.FromTicks(10000);
            var milliseconds = factory.FromMilliseconds(10);

            //Assert
            Assert.NotEqual(ticks.Ticks, milliseconds.Ticks);
        }

        [Fact]
        public void BadDuration_TicksAndSeconds_AreEqual()
        {
            //Arrange
            var factory = new BadDurationFactory();

            //Act
            var ticks = factory.FromTicks(10000000);
            var seconds = factory.FromSeconds(1);
            //Assert
            Assert.Equal(ticks.Ticks, seconds.Ticks);
        }
    }
}
