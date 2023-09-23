using System;
using System.Diagnostics;
using System.Xml;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Main method to test your functions.

            // Add
            Console.WriteLine("Add ---------------------------------");
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(2, 1));
            Console.WriteLine(Add(0, 0));
            Console.WriteLine(Add(10, 10) + " \n");

            //Is Even
            Console.WriteLine("Is Even ---------------------------------");
            Console.WriteLine(IsEven(1));
            Console.WriteLine(IsEven(2));
            Console.WriteLine(IsEven(0));
            Console.WriteLine(IsEven(10) + " \n");

            //Max of three
            Console.WriteLine("Max of three ---------------------------------");
            Console.WriteLine(MaxOfThree(1, 2, 3));
            Console.WriteLine(MaxOfThree(3, 2, 1));
            Console.WriteLine(MaxOfThree(10, 5, 10));
            Console.WriteLine(MaxOfThree(10, 10, 10) + " \n");

            //String length
            Console.WriteLine("String Length ---------------------------------");
            Console.WriteLine(StringLength("a"));
            Console.WriteLine(StringLength("ab"));
            Console.WriteLine(StringLength("abc"));
            Console.WriteLine(StringLength("abcdjsahdksajhkdhaksdhaksajhdkajshdkajhskdjahskjdhaksjdhkajshdkajshdkjahskdhaksdhkajsd") + " \n");

            //Starts hello
            Console.WriteLine("Starts With Hello ---------------------------------");
            Console.WriteLine(StartsHello("Reverse"));
            Console.WriteLine(StartsHello("Hello"));
            Console.WriteLine(StartsHello("   Hello"));
            Console.WriteLine(StartsHello("hello  "));
            Console.WriteLine(StartsHello(" hello") + " \n");

            //Reverse string
            Console.WriteLine("Reverse ---------------------------------");
            Console.WriteLine(ReverseString("Reverse"));
            Console.WriteLine(ReverseString("Hello"));
            Console.WriteLine(ReverseString("esreveR") + " \n");

            //Factorial
            Console.WriteLine("factorial ---------------------------------");
            Console.WriteLine(Factorial(0));
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(2));
            Console.WriteLine(Factorial(3));
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Factorial(8) + " \n");

            Console.WriteLine("factorial but Recursive :) ---------------------------------");
            Console.WriteLine(FacortialButRecursive(0));
            Console.WriteLine(FacortialButRecursive(1));
            Console.WriteLine(FacortialButRecursive(2));
            Console.WriteLine(FacortialButRecursive(3));
            Console.WriteLine(FacortialButRecursive(4));
            Console.WriteLine(FacortialButRecursive(8) + " \n");

            //Is Prime
            Console.WriteLine("Is Prime ---------------------------------");
            Console.WriteLine(IsPrime(0));
            Console.WriteLine(IsPrime(1));
            Console.WriteLine(IsPrime(2));
            Console.WriteLine(IsPrime(3));
            Console.WriteLine(IsPrime(4));
            Console.WriteLine(IsPrime(5) + " \n");

            //Fibonacci
            Console.WriteLine("Fibonacci ---------------------------------");
            Console.WriteLine(Fibonacci(0));
            Console.WriteLine(Fibonacci(2));
            Console.WriteLine(Fibonacci(5));
            Console.WriteLine(Fibonacci(10));
            Console.WriteLine(Fibonacci(11) + " \n");

            //Largest in Array
            Console.WriteLine("Largest In Array ---------------------------------");
            Console.WriteLine(LargestInArray(new int[] { 1, 2, 3 }));
            Console.WriteLine(LargestInArray(new int[] { 3, 2, 1 }));
            Console.WriteLine(LargestInArray(new int[] { 10, 20, 30 }));
            Console.WriteLine(LargestInArray(new int[] { 25, 93, 28, 44, 21 }) + " \n");

            //Is Palindrome
            Console.WriteLine("Is Palindrome ---------------------------------");
            Console.WriteLine(IsPalindrome("racecar"));
            Console.WriteLine(IsPalindrome("ooo"));
            Console.WriteLine(IsPalindrome("tacocat"));
            Console.WriteLine(IsPalindrome("TaCocAT"));
            Console.WriteLine(IsPalindrome("ooguim boga") + " \n");

            //Array Sum
            Console.WriteLine("Array Sum ---------------------------------");
            Console.WriteLine(ArraySum(new int[] { 1, 2, 3 }));
            Console.WriteLine(ArraySum(new int[] { 3, 2, 1 }));
            Console.WriteLine(ArraySum(new int[] { 10, 20, 30 }));
            Console.WriteLine(ArraySum(new int[] { 0, 0, 0 }));
            Console.WriteLine(ArraySum(new int[] { 25, 93, 28, 44, 21 }) + " \n");

            //Char Count
            Console.WriteLine("Char Count ---------------------------------");
            Console.WriteLine(CharCount("tacocat", 'c'));
            Console.WriteLine(CharCount("", 'z'));
            Console.WriteLine(CharCount("zebra", 'z'));
            Console.WriteLine(CharCount("ccccccccc", 'c') + " \n");

            // Concatenate Strings
            Console.WriteLine("Concatenate Strings ---------------------------------");
            Console.WriteLine(ConcatenateStrings("tacocat", "purple"));
            Console.WriteLine(ConcatenateStrings("tacocat", "is green"));
            Console.WriteLine(ConcatenateStrings("", "") + " \n");

            // Swap Ends
            Console.WriteLine("Swap Ends ---------------------------------");
            Console.WriteLine(SwapEnds("hello"));
            Console.WriteLine(SwapEnds("bat"));
            Console.WriteLine(SwapEnds(""));
            Console.WriteLine(SwapEnds("oogum"));

        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            return s.Length;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            string trimmed = s.Trim();
            if (trimmed.StartsWith("Hello") || trimmed.StartsWith("hello"))
                return true;

            return false;

            // Additional answer:
            return trimmed.ToLower().StartsWith("hello");
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;

            int sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            return sum;
        }

        public static int FacortialButRecursive(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return n * FacortialButRecursive(n - 1);
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) // This logic is flawed. This will return true for any number not divisible by 2. Test with 9 as the argument
                    return false;
                else
                    return true;
            }
            return false;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            int n1 = 0;
            int n2 = 1;
            int result = 0;
            for (int i = 2; i < n + 1; i++)
            {
                result = n1 + n2;
                n1 = n2;
                n2 = result;
            }

            return result;
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                int hold = numbers[i];

                if (largest < hold)
                    largest = hold;
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            int j = s.Length;
            int middle = s.Length / 2;
            for (int i = 0; i < middle; i++)
            {
                j--;
                if (s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            string lower = s.ToLower();
            int count = 0;
            foreach (char character in lower)
            {
                if (character == c)
                {
                    count++;
                }
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            return str1 + " " + str2;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            string trimmed = s.Trim();

            if (trimmed.Length <= 1) return s;

            char firstChar = trimmed[0];
            char lastChar = trimmed[trimmed.Length - 1];
            char[] swappedEnds = new char[trimmed.Length];
            swappedEnds[0] = lastChar;

            for (int i = 1; i < trimmed.Length - 1; i++)
            {
                swappedEnds[i] = s[i];
            }

            swappedEnds[swappedEnds.Length - 1] = firstChar;

            string final = new string(swappedEnds);

            return final; //oellh
        }
    }
}
