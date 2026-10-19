namespace MyApp
{
    public static class StringHelper
    {
        // Returns the input string with its characters in reverse order.
        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        // Returns true if the input reads the same forwards and backwards, ignoring case.
        public static bool IsPalindrome(string input)
        {
            string lower = input.ToLowerInvariant();
            return lower == Reverse(lower);
        }

        // Shortens the input to maxLength characters and appends "..." if it was cut.
        public static string Truncate(string input, int maxLength)
        {
            if (maxLength < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxLength), "maxLength cannot be negative.");
            }

            if (input.Length <= maxLength)
            {
                return input;
            }

            return input.Substring(0, maxLength) + "...";
        }
    }
}
