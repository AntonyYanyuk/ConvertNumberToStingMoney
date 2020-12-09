using System;
using System.Collections.Generic;

namespace NumericValuesToString_AntonYaniuk
{
    class LangSelectNumbValidation
    {
        #region Fields
        string _getProgramLanguage = "";
        List<string> _programLang = new List<string>();
        bool _isDotExist;
        int _dotPlace;
        IMoneyConverter _moneyConverter;
        const int _maxAvailableValue = 2147483647;
        #endregion

        internal bool ChooseLanguage()
        {
            bool isLanguageChosen = false;

            while (isLanguageChosen == false)
            {
                Console.WriteLine();
                Console.WriteLine("Choose your language: ukrainian - \"ua\", english - \"eng\".");
                Console.WriteLine("For closing, write \"exit\".");
                Console.WriteLine();

                _getProgramLanguage = Console.ReadLine();

                if (_getProgramLanguage != "ua" && _getProgramLanguage != "eng" && _getProgramLanguage != "exit")
                {
                    Console.WriteLine();
                    Console.WriteLine("Write \"ua\" or \"eng\", and press \"Enter\"!");
                }
                else
                {
                    isLanguageChosen = true;
                }
            }

            if (_getProgramLanguage == "exit")
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                return false;
            }

            else
            {
                return true;
            }
        }

        internal void LanguagePackInitialise()
        {
            LanguagePaks languagePaks = new LanguagePaks();

            if (_getProgramLanguage == "ua")
            {              
                _moneyConverter = new UaMoneyConverter();
                _programLang = languagePaks.GetUaLangPack();
                Console.WriteLine();
                Console.WriteLine(_programLang[0]);
            }
            else
            {
                _moneyConverter = new UsMoneyConverter();
                _programLang = languagePaks.GetEngLangPack();
                Console.WriteLine();
                Console.WriteLine(_programLang[0]);
            }
        }

        internal void GetNumberFromUser()
        {
            string numberOrComand = "";

            while (numberOrComand != _programLang[1])
            {
                _dotPlace = -1;

                Console.WriteLine();
                Console.WriteLine(_programLang[2]);
                Console.WriteLine(_programLang[3]);
                Console.WriteLine();

                _isDotExist = false;

                numberOrComand = Console.ReadLine();

                bool isValidated = Validation(numberOrComand);

                if (isValidated == true)
                {
                    Console.WriteLine(_moneyConverter.NumberToMoneyConvert(numberOrComand, _isDotExist, _dotPlace)); 
                }
            }
        }

        private bool Validation(string usersNumbers)
        {
            if (usersNumbers.Length == 0)
            {
                Console.WriteLine();
                Console.WriteLine(_programLang[12]);
                Console.WriteLine(_programLang[5]);
                Console.ReadKey();
                Console.WriteLine();
                return false;
            }

            if (usersNumbers[0] == '0' && usersNumbers.Length > 1)
            {
               if (usersNumbers[1] != _programLang[7][0])
               {
                    Console.WriteLine();
                    Console.WriteLine(_programLang[14]);
                    Console.WriteLine(_programLang[5]);
                    Console.ReadKey();
                    Console.WriteLine();
                    return false;
                }
            }

            if (usersNumbers == _programLang[1])
            {
                Console.WriteLine();
                Console.WriteLine(_programLang[11]);
                Console.WriteLine(_programLang[5]);
                Console.ReadKey();
                Console.WriteLine();
                return false;
            }

            if (usersNumbers[0] == '-' && usersNumbers.Length > 1)
            {
                Console.WriteLine();
                Console.WriteLine(_programLang[4]);
                Console.WriteLine(_programLang[5]);
                Console.ReadKey();
                Console.WriteLine();
                return false;
            }

            if (_getProgramLanguage == "ua" && usersNumbers.Contains('.'))
            {
                Console.WriteLine();
                Console.WriteLine(_programLang[10]);
                Console.WriteLine(_programLang[5]);
                Console.ReadKey();
                Console.WriteLine();
                return false;
            }

            _dotPlace = usersNumbers.IndexOf(_programLang[7]);

            if (_dotPlace != -1)
            {
                if ((usersNumbers.Length - _dotPlace) - 1 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(_programLang[6]);
                    Console.WriteLine(_programLang[5]);
                    Console.ReadKey();
                    Console.WriteLine();
                    return false;
                }
                if ((usersNumbers.Length - _dotPlace) - 1 > 2)
                {
                    Console.WriteLine();
                    Console.WriteLine(_programLang[8]);
                    Console.WriteLine(_programLang[5]);
                    Console.ReadKey();
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    if (_getProgramLanguage == "ua")
                    {
                        usersNumbers = usersNumbers.Replace(usersNumbers[_dotPlace], '.');
                    }
                    _isDotExist = true;
                }
            }

            decimal number;

            try
            {
                number = Convert.ToDecimal(usersNumbers);
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine(_programLang[9]);
                Console.WriteLine(_programLang[5]);
                Console.ReadKey();
                Console.WriteLine();
                return false;
            }

            if (number > _maxAvailableValue)
            {
                Console.WriteLine();
                Console.WriteLine(_programLang[13]);
                Console.WriteLine(_programLang[5]);
                Console.ReadKey();
                Console.WriteLine();
                return false;
            }

            return true;
        }
    }
}
