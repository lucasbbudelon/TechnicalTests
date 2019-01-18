using System;
using System.Text.RegularExpressions;

namespace ReverseStringWhileKeepingDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "ab1c2de345f";
            string modified = ReverseString(original);
            bool test = modified.Equals("fe1d2cb345a");
            Console.WriteLine(modified);
        }

        static string ReverseString(string text)
        {
            char[] modified = text.ToCharArray();

            int start = 0, finish = modified.Length - 1;

            while (start < finish)
            {
                if (IsDigit(modified[finish]))
                {
                    finish--;
                }
                else
                {
                    if (IsDigit(modified[start]))
                    {
                        start++;
                    }
                    else
                    {
                        char temp = modified[finish];
                        modified[finish] = modified[start];
                        modified[start] = temp;

                        finish--;
                        start++;
                    }
                }
            }

            return new string(modified);
        }

        static bool IsDigit(char digit)
        {
            return Regex.IsMatch(digit.ToString(), @"^\d+$");
        }
    }
}
