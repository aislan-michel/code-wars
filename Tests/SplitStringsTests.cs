using CodeWars;
using Xunit;

namespace Tests
{
    public class SplitStringsTests
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal(new[] { "ab", "c_" }, SplitStrings.Execute("abc"));
            Assert.Equal(new[] { "ab", "cd", "ef" }, SplitStrings.Execute("abcdef"));
        }
    }
}