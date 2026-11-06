using RegularExpressionLib.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorTest
{
    public class UnitTestPhone
    {
        [Theory]
        [InlineData("12345678")]
        [InlineData("+45 12345678")]
        [InlineData("+4512345678")]
        public void TestPhoneAccept(String phone)
        {
            //assert
            Assert.True(MyValidator.CheckPhone(phone));
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("1234567")]
        [InlineData("123456789")]
        [InlineData(" 12345678")]
        [InlineData("1234m678")]
        [InlineData("-45 12345678")]
        [InlineData("+45 123456789")]
        [InlineData("+ab 12345678")]
        public void TestPhoneNotAccept(String phone)
        {
            //assert
            Assert.False(MyValidator.CheckPhone(phone));
        }
    }
}
