using RegularExpressionLib.Validation;

namespace ValidatorTest
{
    public class UnitTestName
    {
        [Theory]
        [InlineData("p")]
        [InlineData("pe")]
        [InlineData("peter")]
        [InlineData("Peter")]
        [InlineData("Jens-Peter")]
        [InlineData("Peter Levinsky")]
        [InlineData("Hr. Peter")]
        public void TestNameAccept(string name)
        {
            //assert
            Assert.True(MyValidator.CheckName(name));
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" peter")] // starting with a space
        [InlineData("peter8")]
        [InlineData("peter()")]
        public void TestNameNotAccept(string name)
        {
            //assert
            Assert.False(MyValidator.CheckName(name));
        }
    }
}
