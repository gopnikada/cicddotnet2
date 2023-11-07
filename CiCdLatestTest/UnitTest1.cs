using CiCdLatest;
using FluentAssertions;
using Xunit;

namespace CiCdLatestTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var oldCar = new Car(1995);
            var modernCar = new Car(2005);
            var newCar = new Car(2020);
            //act
            var resultOldCar = oldCar.GetYear();
            var resultModernCar = modernCar.GetYear();
            var resultNewCar = newCar.GetYear();
            //assert
            resultOldCar.Should().Be("old");
            resultModernCar.Should().Be("modern");
            resultNewCar.Should().Be("new");

            //Assert.Equal("old", resultOldCar);
            //test1
        }
    }
}