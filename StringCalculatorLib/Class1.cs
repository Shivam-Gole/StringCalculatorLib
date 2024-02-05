using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculatorLib
{

        public static class StringCalculator
        {
            public static int Add(string numbersString)
            {
                if (string.IsNullOrWhiteSpace(numbersString))
                {
                    return 0;
                }

                string[] numbers = numbersString.Split(',', '\n');

                int sum = 0;

                foreach (var number in numbers)
                {
                    int parsedNumber = ParseNumber(number);
                    EnsureNonNegative(parsedNumber);
                    sum += parsedNumber;
                }

                return sum;
            }

        private static int ParseNumber(string number)
        {
            int parsedNumber = ParseInteger(number);
            EnsureNoLeadingZeros(number, parsedNumber);
            return parsedNumber;
        }

        private static int ParseInteger(string number)
        {
            if (!int.TryParse(number, out int parsedNumber))
            {
                throw new ArgumentException("Invalid number format.");
            }
            return parsedNumber;
        }

        private static void EnsureNoLeadingZeros(string number, int parsedNumber)
        {
            if (number.Length > 1 && number[0] == '0')
            {
                throw new ArgumentException("Numbers with leading zeros are not allowed.");
            }
        }

        private static void EnsureNonNegative(int number)
        {
                if (number < 0)
                {
                    throw new ArgumentException("Negative numbers are not allowed.");
                }
            }
        }
}


   