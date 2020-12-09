using System;

namespace NumericValuesToString_AntonYaniuk
{
    class UsMoneyConverter : IMoneyConverter
    {
        #region EngStringNumbers
        static string[] ones = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "tourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        static string[] tens = new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        static string[] thousandsGroups = { "", " thousand", " million", " billion" };
        #endregion

        private string NumberToString(int n, string leftDigits, int thousands)
        {
            if (n == 0)
            {
                return leftDigits;
            }

            string friendlyInt = leftDigits;

            if (friendlyInt.Length > 0 && leftDigits[leftDigits.Length - 1] != '-')
            {
                friendlyInt += " ";
            }

            if (n < 10)
            {
                friendlyInt += ones[n];
            }
            else if (n < 20)
            {
                friendlyInt += teens[n - 10];
            }
            else if (n < 100)
            {
                var rest = n % 10;
                var leftStr = rest == 0 ? tens[n / 10 - 2] : tens[n / 10 - 2] + '-';
                friendlyInt += NumberToString(n % 10, leftStr, 0);
            }
            else if (n < 1000)
            {
                friendlyInt += NumberToString(n % 100, (ones[n / 100] + " hundred"), 0);
            }
            else
            {
                friendlyInt += NumberToString(n % 1000, NumberToString(n / 1000, "", thousands + 1), 0);
                if (n % 1000 == 0)
                {
                    return friendlyInt;
                }
            }
            return friendlyInt + thousandsGroups[thousands];
        }

        public string NumberToMoneyConvert(string stringNumber, bool isDotExist, int dotPlace)
        {
            int dollars, cents;
            string dollarsString, centsString;
            cents = 1;
            if (isDotExist)
            {
                dollars = Convert.ToInt32(stringNumber.Substring(0, dotPlace));

                if(dotPlace == stringNumber.Length - 2)
                {
                    stringNumber = stringNumber + "0";
                    cents = Convert.ToInt32(stringNumber.Substring(dotPlace + 1));
                }
                else
                {
                    cents = Convert.ToInt32(stringNumber.Substring(dotPlace + 1));
                }               
            }
            else
            {
                dollars = Convert.ToInt32(stringNumber);
            }

            if (dollars != 0)
            {
                dollarsString = NumberToString(dollars, "", 0);
            }
            else
            {
                dollarsString = "zero";
            }

            if (isDotExist == true && cents != 0)
            {
                centsString = NumberToString(cents, "", 0);
            }
            else
            {
                centsString = "zero";
            }

            var result = "";

            if (isDotExist == true)
            {
                if (dollars == 1)
                {
                    result = dollarsString + " dollar ";
                }
                else
                {
                    result = dollarsString + " dollars ";
                }
            }
            else
            {
                if (dollars == 1)
                {
                    result = dollarsString + " dollar ";
                }
                else
                {
                    result = dollarsString + " dollars ";
                }
            }              

            if (isDotExist)
            {
                if (cents == 1)
                {
                    result = result + centsString + " cent";
                }
                else
                {
                    result = result + centsString + " cents";
                }
            }                      
            return result;
        }
    }
}
