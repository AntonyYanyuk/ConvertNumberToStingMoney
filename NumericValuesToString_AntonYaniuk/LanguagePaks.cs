using System.Collections.Generic;

namespace NumericValuesToString_AntonYaniuk
{
    class LanguagePaks
    {
        #region Ua
        public List<string> GetUaLangPack()
        {
            List<string> usersLang = new List<string>();
            usersLang.Add("Програма виводить на екан сумму в гривні прописом для " +
                "будь-якого введеного вами числа в межах від 0 до 2147483647 включно.");    // 0
            usersLang.Add("закрити");                                                       // 1
            usersLang.Add("Введіть будь-яке число від 0 до 2147483647, " +    
                "число може мати дробну частину для копійок (вказується після коми).");     // 2
            usersLang.Add("Для виходу, введіть \"закрити\".");                              // 3
            usersLang.Add("Число не може бути негативне!");                                 // 4
            usersLang.Add("Для продовження натисніть будь-яку кнопку.");                    // 5
            usersLang.Add("Після коми мають бути числа, для вказання дробної частини!");    // 6
            usersLang.Add(",");                                                             // 7
            usersLang.Add("Дробна частина може мати максимум два числа!");                  // 8
            usersLang.Add("Пишіть лише числа!");                                            // 9 
            usersLang.Add("Для вказання дробної частини використовуйте кому!");             // 10
            usersLang.Add("Програма закрита.");                                             // 11
            usersLang.Add("Напишіть числа, потім натисніть \"Enter\"!");                    // 12
            usersLang.Add("Значення не може бути більшим ніж число \"2147483647\"!");       // 13
            usersLang.Add("Якщо перше число нуль, після введіть кому для дробної частини!");// 14
            return usersLang;
        }

        public List<string> GetUaLangNumbers()
        {
            List<string> usersLangNumbers = new List<string>();
            usersLangNumbers.Add("нуль ");           // 0
            usersLangNumbers.Add("один ");           // 1
            usersLangNumbers.Add("два ");            // 2
            usersLangNumbers.Add("три ");            // 3
            usersLangNumbers.Add("чотири ");         // 4
            usersLangNumbers.Add("п'ять ");          // 5
            usersLangNumbers.Add("шість ");          // 6
            usersLangNumbers.Add("сім ");            // 7
            usersLangNumbers.Add("вісім ");          // 8
            usersLangNumbers.Add("дев'ять ");        // 9
            usersLangNumbers.Add("десять ");         // 10
            usersLangNumbers.Add("одинадцять ");     // 11
            usersLangNumbers.Add("дванадцять ");     // 12
            usersLangNumbers.Add("тринадцять ");     // 13
            usersLangNumbers.Add("чотирнадцять ");   // 14
            usersLangNumbers.Add("п'ятнадцять ");    // 15
            usersLangNumbers.Add("шіснадцять ");     // 16
            usersLangNumbers.Add("сімнадцять ");     // 17
            usersLangNumbers.Add("вісімнадцять ");   // 18
            usersLangNumbers.Add("дев'ятнадцять ");  // 19
            usersLangNumbers.Add("двадцять ");       // 20
            usersLangNumbers.Add("тридцять ");       // 21
            usersLangNumbers.Add("сорок ");          // 22
            usersLangNumbers.Add("п'ятдесят ");      // 23
            usersLangNumbers.Add("шістдесят ");      // 24
            usersLangNumbers.Add("сімдесят ");       // 25
            usersLangNumbers.Add("вісімдесят ");     // 26
            usersLangNumbers.Add("дев'яносто ");     // 27
            usersLangNumbers.Add("сто ");            // 28
            usersLangNumbers.Add("двісті ");         // 29
            usersLangNumbers.Add("триста ");         // 30
            usersLangNumbers.Add("чотириста ");      // 31
            usersLangNumbers.Add("п'ятсот ");        // 32
            usersLangNumbers.Add("шістсот ");        // 33
            usersLangNumbers.Add("сімсот ");         // 34
            usersLangNumbers.Add("вісімсот ");       // 35
            usersLangNumbers.Add("тисяча ");         // 36
            usersLangNumbers.Add("мільйон ");        // 37
            usersLangNumbers.Add("мільярд ");        // 38
            usersLangNumbers.Add("одна ");           // 39
            usersLangNumbers.Add("тисячі ");         // 40
            usersLangNumbers.Add("мільйони ");       // 41
            usersLangNumbers.Add("мільярда ");       // 42
            usersLangNumbers.Add("мільярд ");        // 43
            usersLangNumbers.Add("мільярд ");        // 44
            usersLangNumbers.Add("одна ");           // 45
            usersLangNumbers.Add("дві ");            // 46
            usersLangNumbers.Add("мільйонів ");      // 47
            usersLangNumbers.Add("мільйон ");        // 48
            usersLangNumbers.Add("тисяча ");         // 49
            usersLangNumbers.Add("тисяч ");          // 50
            usersLangNumbers.Add("мільйона ");       // 51
            return usersLangNumbers;
        }
        #endregion

        #region Eng
        public List<string> GetEngLangPack()
        {
            List<string> usersLang = new List<string>();
            usersLang.Add("The program displays the amount in dollars for any " +
                "the number you enter in the range from 0 to 2147483647 inclusive.");               // 0
            usersLang.Add("close");                                                                 // 1
            usersLang.Add("Enter any number from 0 to 2147483647, " +
                "the number can have a fraction part for cents (indicated after the dot).");        // 2
            usersLang.Add("To exit, enter \"close\".");                                             // 3
            usersLang.Add("The number cannot be negative!");                                        // 4
            usersLang.Add("Press any button to continue.");                                         // 5
            usersLang.Add("After dot must be numbers to indicate a fraction part!");                // 6
            usersLang.Add(".");                                                                     // 7
            usersLang.Add("The fractional part can have a maximum of two numbers!");                // 8
            usersLang.Add("Write only numbers!");                                                   // 9 
            usersLang.Add("");                                                                      // 10
            usersLang.Add("Program closed.");                                                       // 11
            usersLang.Add("Write the numbers, then click \"Enter\"!");                              // 12
            usersLang.Add("The value cannot be greater than the number \"2147483647\"!");           // 13
            usersLang.Add("If the first number is zero, then enter a dot for the fractional part!");// 14
            return usersLang;
        }
        #endregion
    }
}
