namespace BasicCodingForDSA
{
    public class BasicCoding
    {
        // 1. Take a number and print whether it’s positive, negative, or zero.
        public void CheckNumber()
        {
            Console.WriteLine("Enter an number :");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (n < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Positive");
            }
        }

        // 2. Check if a number is even or odd.
        public void CheckEvenOdd()
        {
            Console.WriteLine("Enter an Number :");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

        // 3. Check if a number is divisible by 5.
        public void CheckDivisibleBy5()
        {
            Console.WriteLine("Enter an Number :");
            int n = int.Parse(Console.ReadLine());
            if (n % 5 == 0)
            {
                Console.WriteLine("Yuup!! The Number: " + n + " is divisble by 5");
            }
            else
            {
                Console.WriteLine("Noop!! The number: " + n + " is not divisble by 5");
            }
        }

        // 4. Check if a number is divisible by both 3 and 5.
        public void CheckDivisibleByBoth5and3()
        {
            Console.WriteLine("Enter an number");
            int n = int.Parse(Console.ReadLine());
            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("Yuup!! its divisible by both 3 and 5");
            }
            else
            {
                Console.WriteLine("Noop!! its not divisble by both 3 and 5");
            }
        }

        // 5. Check if a given year is a leap year.
        public void CheckIsLeapYear()
        {
            Console.WriteLine("Enter an number:");
            int n = int.Parse(Console.ReadLine());
            // 1. Divisible by 400 or divisible by 4 but not by 100 
            if ((n % 400 == 0) || (n % 4 == 0 && n % 100 != 0))
            {
                Console.WriteLine("Its Leap Year!!");
            }
            else
            {
                Console.WriteLine("No!, Its not a Leap Year!!");
            }
        }

        // 6. Take two numbers and print the larger one.
        public void CheckLargeIn2Number()
        {
            Console.WriteLine("Enter first number :");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("Largest Number is : " + n1);
            }
            else
            {
                Console.WriteLine("Largest Number is : " + n2);
            }
        }

        // 7. Take three numbers and print the largest.
        public void CheckLargeIn3Number()
        {
            Console.WriteLine("Enter 3 number comma separted: ");
            string? input = Console.ReadLine();
            string[] numbers = input.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (numbers.Length == 3)
            {
                int n1 = int.Parse(numbers[0]);
                int n2 = int.Parse(numbers[1]);
                int n3 = int.Parse(numbers[2]);
                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine("Largest Number is : " + n1);
                }
                else if (n2 > n3 && n2 > n1)
                {
                    Console.WriteLine("Largest Number is :" + n2);
                }
                else
                {
                    Console.WriteLine("Largest Number is :" + n3);
                }
                // another built-in approch using Math.Max() function its take two value to check large 
                Console.WriteLine("Largest Number is : " + Math.Max(n1, Math.Max(n2, n3)));
            }
            else
            {
                return;
            }
        }

        // 8. Take a temperature value and print “Cold”, “Warm”, or “Hot” using range conditions.
        public void CheckWeather()
        {
            Console.WriteLine("Enter temperature in format like (e.g. 30F or 20C)");
            string? input = Console.ReadLine().ToUpper().Trim();
            if (input.Length < 2)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            char unit = input[input.Length - 1];
            string value = input.Substring(0, input.Length - 1);
            if (unit == 'F' || unit == 'C')
            {
                if (double.TryParse(value, out double temperature))
                {
                    if (unit == 'F') temperature = (temperature - 32) / 1.8;
                    if (temperature < 10)
                    {
                        Console.WriteLine("It's Cold Now");
                    }
                    else if (temperature >= 10 && temperature < 25)
                    {
                        Console.WriteLine("It's Warm Now");
                    }
                    else
                    {
                        Console.WriteLine("It's Hot Now");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Temperature !!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Unit !!");
            }
        }

        // 9. Take a character and check if it’s a vowel or consonant.
        public void CheckVowelOrConsonant()
        {
            Console.WriteLine("Enter a character: ");
            string? input = Console.ReadLine()?.ToLower().Trim();
            if (string.IsNullOrWhiteSpace(input)) return;
            char value = input[0];

            if (value == 'a' || value == 'e' || value == 'i' || value == 'o' || value == 'u')
            {
                Console.WriteLine("It's vowel !!");
            }
            else if (char.IsLetter(value))
            {
                Console.WriteLine("It's a consonant !!");
            }
            else
            {
                Console.WriteLine("Invalid character !!");
            }
        }

        // 10. Take a character and check whether it’s uppercase, lowercase, a digit, or a special
        // character.
        public void CheckCharacterType()
        {
            Console.WriteLine("Enter a character: ");
            string? input = Console.ReadLine()?.Trim();
            if (string.IsNullOrWhiteSpace(input)) return;
            char value = input[0];
            if (char.IsDigit(value))
            {
                Console.WriteLine("Its digit");
            }
            else if (char.IsLetter(value))
            {
                if (char.IsUpper(value))
                {
                    Console.WriteLine("Its Uppercase");
                }
                else
                {
                    Console.WriteLine("it's lowercase");
                }
            }
            else
            {
                Console.WriteLine("Its Special");
            }
        }
    }
}