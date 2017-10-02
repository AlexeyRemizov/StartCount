//using ConsoleApp2;
using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace StartCountTest
{
    public class TestOfAmountOurStartCount
    {
        [Fact]
        public void PositiveTestStartCount()
        {
            //Arrange
            GetRange getRangeTest = new GetRange();
            //Act
            int resultOfAmount = getRangeTest.StartCount(1,8).Count();
            //Assert
            Assert.Equal(8, resultOfAmount);
        }

        [Fact]
        public void NegativeTestStartCount()
        {
            GetRange getRangeTest1 = new GetRange();
            var resultOfAmount = getRangeTest1.StartCount(5, 3).Count();
            Assert.Equal(5, resultOfAmount);
        }
    }
}
