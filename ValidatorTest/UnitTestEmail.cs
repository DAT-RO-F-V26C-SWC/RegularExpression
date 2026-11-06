using RegularExpressionLib.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorTest
{
    public class UnitTestEmail
    {
        [Theory]
        [InlineData("peter@mail.dk")]
        [InlineData("peter-levinsky@mail.dk")]
        [InlineData("peter56@mail.dk")]
        [InlineData("peter.levinsky@mail.dk")]
        [InlineData("p@f.g.h")]
        [InlineData("p.p.p.p@m.dk")]
        public void TestEMailAccept(string email)
        {
            //assert
            Assert.True(MyValidator.CheckEmail(email));
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" peter56@mail.dk")] // starts with space
        [InlineData("p.l@dk")]
        [InlineData("p.mail.dk")]
        [InlineData("p@mail.longTopDomain")]
        public void TestEMailNotAccept(string email)
        {
            //assert
            Assert.False(MyValidator.CheckEmail(email));
        }

    }
}
