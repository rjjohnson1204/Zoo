using System;
using Xunit;
using Zoo;
using Zoo.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Gecko()
        {
            Gecko gecko = new Gecko();

            Assert.Equal("My tail grows back!!", gecko.GrowTailBack());

        }
        [Fact]
        public void Golden_Monkey()
        {
            Golden_Monkey monkey = new Golden_Monkey();

            Assert.Equal("I swing from trees!!", monkey.Swing());
        }
        [Fact]
        public void Elk()
        {
            Elk elk = new Elk();
            Assert.Equal(4, elk.Legs);
        }
        [Fact]
        public void Sea_turtle()
        {
            Sea_turtle turtle = new Sea_turtle();
            //Assert.Equal(turtle.Sleep());
        }
    }
}
