namespace BasicCodingForDSA.Strings
{
    public class StringQuestion
    {
        public void CheckStringPalindrome()
        {
            Console.WriteLine("Enter a String");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return;
            ReadOnlySpan<char> span = input.AsSpan();
            int left = 0;
            int right = span.Length - 1;

            bool isPalindrome = true;
            while (left < right)
            {
                if (char.ToLowerInvariant(span[left]) != char.ToLowerInvariant(span[right]))
                {
                    isPalindrome = false;
                    break;
                }
                left++;
                right--;
            }
            Console.WriteLine(isPalindrome ? "It's a palindrome" : "No, it's not a palindrome");
        }
        
    }
}