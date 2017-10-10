//using ConsoleApp2;
using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCount;

namespace StartCountTest
{
    public class TestOfAmountOurStartCount
    {
        [Fact]
        public void PositiveTestStartCount()
        {
            //Arrange
            var getRangeTest = new GetRange();
            //Act
            var resultOfAmount = getRangeTest.StartCount(1,8).Count();
            //Assert
            Assert.Equal(8, resultOfAmount);
        }

        [Fact]
        public void NegativeTestStartCount()
        {
            var getRangeTest1 = new GetRange();
            var resultOfAmount = getRangeTest1.StartCount(5, 3).Count();
            Assert.Equal(5, resultOfAmount);
        }

        [Fact]
        public void PositiveSumOfAllElementsEventsArgs(SumOfAllElementsEventArgs e)
        {
            //Arrange
            var getRangeTest2 = new GetRange();
            //Act
            int resultOfEvent = e.SumOfAllElements;
            //Assert
            Assert.Equal(52, resultOfEvent);
            
        }
    }
}
