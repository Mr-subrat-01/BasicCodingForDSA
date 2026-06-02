using BasicCodingForDSA;
using BasicCodingForDSA.Strings;
public class Program
{
    public static void Main(string[] args)
    {
        var bs = new BasicCoding();
        var sq = new StringQuestion();
        var aq = new ArrayQuestion();
        while (true)
        {
            try
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Choose your choice: ");
                Console.WriteLine("1. Check Number: ");
                Console.WriteLine("2. Check EvenOdd: ");
                Console.WriteLine("3. Check Divisible By 5: ");
                Console.WriteLine("4. Check Divisible By both 3 and 5: ");
                Console.WriteLine("5. Check Leap Year: ");
                Console.WriteLine("6. Check Large In 2 Number: ");
                Console.WriteLine("7. Check Large In 3 Number: ");
                Console.WriteLine("8. Check Weather: ");
                Console.WriteLine("9. Check Vowel Or Consonant: ");
                Console.WriteLine("10. Check Characte Type: ");
                Console.WriteLine("30. Check String Palindrome");
                Console.WriteLine("31. Find Min and Max element in array:");
                Console.WriteLine("32. Reverse an array:");
                Console.WriteLine("33. Contains Duplicate:");
                Console.WriteLine("34. Find All Duplicate:");
                Console.WriteLine("0. Exit: ");
                Console.WriteLine("=============================");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        bs.CheckNumber();
                        break;
                    case 2:
                        bs.CheckEvenOdd();
                        break;
                    case 3:
                        bs.CheckDivisibleBy5();
                        break;
                    case 4:
                        bs.CheckDivisibleByBoth5and3();
                        break;
                    case 5:
                        bs.CheckIsLeapYear();
                        break;
                    case 6:
                        bs.CheckLargeIn2Number();
                        break;
                    case 7:
                        bs.CheckLargeIn3Number();
                        break;
                    case 8:
                        bs.CheckWeather();
                        break;
                    case 9:
                        bs.CheckVowelOrConsonant();
                        break;
                    case 10:
                        bs.CheckCharacterType();
                        break;
                    case 30:
                        sq.CheckStringPalindrome();
                        break;
                    case 31:
                        aq.FindMinAndMaxInArray();
                        break;
                    case 32:
                        aq.ReverseAnArray();
                        break;
                    case 33:
                        aq.ContainsDuplicate();
                        break;
                    case 34:
                        aq.FindAllDuplicate();
                        break;
                    case 0:
                        Console.WriteLine("Thank You!!");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message + " Try Again!! ");
            }
        }
    }
}