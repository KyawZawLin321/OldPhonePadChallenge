using Microsoft.VisualStudio.TestPlatform.TestHost;
using OldPhonePadChallenge;
using Xunit;

namespace Tests
{
    public class OldPhonePadTests
    {
        [Theory]
        [InlineData("2#", "A")]
        [InlineData("222#", "C")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "TURING")]
        [InlineData("1#", ".")]
        [InlineData("11#", ",")]
        [InlineData("111#", "!")]
        [InlineData("1111#", "?")]
        public void TestOldPhonePad(string input, string expected)
        {
            var result = OldPhone.OldPhonePad(input);
            Assert.Equal(expected, result);
        }
    }
}
