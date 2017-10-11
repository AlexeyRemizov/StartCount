using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCount;
using System.Threading;

namespace StartCount.Tests
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
            Assert.False(5.Equals(resultOfAmount));
        }

        [Fact]
        public void PositiveSumOfAllElementsEventsArgs()
        {
            //Arrange
            var getRangeTest2 = new GetRange();
            SumOfAllElementsEventArgs args = null;
            getRangeTest2.SumOfAllElementsEA += (s,e) => { args = e; };
            
            //Act
            getRangeTest2.StartCount(3, 8).ToList();
            
            //Assert
            Assert.Equal(52, args.SumOfAllElements);
            
        }

        /*private void GetRangeTest2_MySumOfAllElements(object sender, SumOfAllElementsEventArgs e)
        {
            throw new NotImplementedException();
        }*/

    }
}
