using RegularExpressionLib.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorTest
{
    public class UnitTestHouseNumber
    {
        [Theory]
        [InlineData("4")]
        [InlineData("167")]
        [InlineData("167 B")]
        [InlineData("167B")]
        [InlineData("1 1")]
        [InlineData("17 1 tv")]
        [InlineData("17X 1tv")]
        [InlineData("17 1.tv")]
        public void TestHouseNumberAccept(string houseNumber)
        {
            //assert
            Assert.True(MyValidator.CheckHouseNumber(houseNumber));
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("a17 1 tv")]
        [InlineData("17 1#")]
        public void TestHouseNumberNotAccept(string houseNumber)
        {
            //assert
            Assert.False(MyValidator.CheckHouseNumber(houseNumber));
        }

    }
}
