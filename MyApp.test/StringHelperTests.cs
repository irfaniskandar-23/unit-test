namespace MyApp.test
{
    public class StringHelperTests
    {
        // ---------- Reverse ----------

        [Fact]
        public void Reverse_SimpleWord_ReturnsReversedWord()
        {
            // Arrange
            string input = "hello";

            // Act
            string result = StringHelper.Reverse(input);

            // Assert
            Assert.Equal("olleha", result);
        }

        [Fact]
        public void Reverse_EmptyString_ReturnsEmptyString()
        {
            string result = StringHelper.Reverse("");

            Assert.Equal("", result);
        }

        // ---------- IsPalindrome ----------

        [Theory]
        [InlineData("racecar")]
        [InlineData("Level")]
        [InlineData("a")]
        public void IsPalindrome_PalindromeWords_ReturnsTrue(string input)
        {
            bool result = StringHelper.IsPalindrome(input);

            Assert.True(result);
        }

        [Theory]
        [InlineData("hello")]
        [InlineData("dotnet")]
        public void IsPalindrome_NonPalindromeWords_ReturnsFalse(string input)
        {
            bool result = StringHelper.IsPalindrome(input);

            Assert.False(result);
        }

        // ---------- Truncate ----------

        [Fact]
        public void Truncate_InputLongerThanMax_CutsAndAddsEllipsis()
        {
            string result = StringHelper.Truncate("Hello World", 5);

            Assert.Equal("Hello...", result);
        }

        [Fact]
        public void Truncate_InputShorterThanMax_ReturnsInputUnchanged()
        {
            string result = StringHelper.Truncate("Hi", 5);

            Assert.Equal("Hi", result);
        }

        [Fact]
        public void Truncate_NegativeMaxLength_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => StringHelper.Truncate("Hello", -1));
        }
    }
}
