using RegularExpressionLib.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorTest
{
    public class UnitTestZip
    {
        [Theory]
        [InlineData("1234")]
        public void TestZipAccept(String zip)
        {
            //assert
            Assert.True(MyValidator.CheckZip(zip));
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("123")]
        [InlineData("12345")]
        [InlineData(" 4567")]
        [InlineData("4567 ")]
        [InlineData("a1234")]
        [InlineData("567#")]
        public void TestZipNotAccept(String zip)
        {
            //assert
            Assert.False(MyValidator.CheckZip(zip));
        }
    }
}
