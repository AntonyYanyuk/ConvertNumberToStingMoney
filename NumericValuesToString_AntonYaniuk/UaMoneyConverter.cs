using System.Collections.Generic;
using System.Text;

namespace NumericValuesToString_AntonYaniuk
{
    class UaMoneyConverter : LanguagePaks, IMoneyConverter
    {
        #region Fields
        private LanguagePaks _languagePaks = new LanguagePaks();
        List<string> _uaStringNumbers = new List<string>();
        StringBuilder _convertedNumber = new StringBuilder();
        StringBuilder _valueAfterDot = new StringBuilder();
        bool _isAppendingBeforeMilion = true;
        bool _isOneNumber = false;
        #endregion

        public string NumberToMoneyConvert(string stringNumber, bool isDotExist, int dotPlace)
        {
            if (_convertedNumber.Length != 0)
            {
                _convertedNumber.Clear();
                _valueAfterDot.Clear();
            }

            StringBuilder enteredNumber = new StringBuilder(stringNumber);
            _uaStringNumbers = _languagePaks.GetUaLangNumbers();

            #region RemoveStringAfterDot
            if (isDotExist == true)
            {
                enteredNumber.Remove(dotPlace, 1);
                int i = dotPlace;
                bool isOnePartialNumber = true;
                    if (i == enteredNumber.Length - 2)
                    {
                         if (enteredNumber[i] == '1')
                         {
                            _valueAfterDot.Append(GetUaAfterNine(enteredNumber[i]));

                            _valueAfterDot.Append("копійок");

                            enteredNumber.Remove(i, 2);
                         }
                         else
                         {
                            _valueAfterDot.Append(GetUaTens(enteredNumber[i]));
                            enteredNumber.Remove(i, 1);
                 
                           if (enteredNumber[i] == '0')
                           {
                            enteredNumber.Remove(i, 1);
                           }
                            isOnePartialNumber = false;
                         }
                    }

                    if (i == enteredNumber.Length - 1)
                    {
                    if (isOnePartialNumber == false)
                    {
                        _isOneNumber = true;

                        _valueAfterDot.Append(GetUaFromZeroToNine(enteredNumber[i]));

                        if (enteredNumber[i] == '1')
                        {
                            _valueAfterDot.Append("копійка ");
                        }
                        else if (enteredNumber[i] == '2' || enteredNumber[i] == '3' || enteredNumber[i] == '4')
                        {
                            _valueAfterDot.Append("копійки ");
                        }
                        else
                        {
                            _valueAfterDot.Append("копійок ");
                        }
                        enteredNumber.Remove(i, 1);
                    }
                    else
                    {                      
                        if (enteredNumber[i] != '0')
                        {
                            _valueAfterDot.Append(GetUaTens(enteredNumber[i]));
                        }
                        else
                        {
                            _valueAfterDot.Append(_uaStringNumbers[0]);
                        }
                        _valueAfterDot.Append("копійок ");
                        enteredNumber.Remove(i, 1);
                    }
                    }                              
            }
            #endregion

            _isAppendingBeforeMilion = false;

            if (enteredNumber.Length > 1)
            {
                _isOneNumber = false;
            }
            else
            {
                _isOneNumber = true;
            }              

            if (enteredNumber.Length == 10)
            {
                if (stringNumber[0] == '1')
                {
                    _convertedNumber.Append(_uaStringNumbers[1]);
                    _convertedNumber.Append(_uaStringNumbers[38]);
                }
                else
                {
                    _convertedNumber.Append(_uaStringNumbers[2]);
                    _convertedNumber.Append(_uaStringNumbers[42]);
                }
                enteredNumber.Remove(0, 1);

                if (enteredNumber[0] == '0' && enteredNumber[1] == '0' && enteredNumber[2] == '0')
                {
                    enteredNumber.Remove(0, 3);
                }
            }
            if (enteredNumber.Length == 9)
            {
                _convertedNumber.Append(GetUaHundreds(enteredNumber[0]));
                enteredNumber.Remove(0, 1);
            }

            if (enteredNumber.Length == 8)
            {
                if (enteredNumber[0] == '1')
                {
                    _convertedNumber.Append(GetUaAfterNine(enteredNumber[1]));

                    _convertedNumber.Append(_uaStringNumbers[47]);

                    enteredNumber.Remove(0, 2);
                }
                else
                {
                    _convertedNumber.Append(GetUaTens(enteredNumber[0]));
                    enteredNumber.Remove(0, 1);
                }
            }
            if (enteredNumber.Length == 7)
            {
                _convertedNumber.Append(GetUaFromZeroToNine(enteredNumber[0]));

                if (enteredNumber[0] == '1')
                {
                    _convertedNumber.Append(_uaStringNumbers[48]);
                } 
                else if (enteredNumber[0] == '4')
                {
                    _convertedNumber.Append(_uaStringNumbers[51]);
                }
                else if (enteredNumber[0] == '2' || enteredNumber[0] == '3')
                {
                    _convertedNumber.Append(_uaStringNumbers[41]);
                }
                else
                {
                    _convertedNumber.Append(_uaStringNumbers[47]);
                }
                enteredNumber.Remove(0, 1);
            }

            if (enteredNumber.Length == 6)
            {
                if (enteredNumber[0] == '0' && enteredNumber[1] == '0' && enteredNumber[2] == '0')
                {
                    enteredNumber.Remove(0, 3);
                }
                _convertedNumber.Append(GetUaHundreds(enteredNumber[0]));
                enteredNumber.Remove(0, 1);
            }

            if (enteredNumber.Length == 5)
            {
                if (enteredNumber[0] == '1')
                {
                    _convertedNumber.Append(GetUaAfterNine(enteredNumber[1]));

                    _convertedNumber.Append(_uaStringNumbers[50]);

                    enteredNumber.Remove(0, 2);
                }
                else
                {
                    _convertedNumber.Append(GetUaTens(enteredNumber[0]));
                    enteredNumber.Remove(0, 1);
                }
            }

            if (enteredNumber.Length == 4)
            {
                _isAppendingBeforeMilion = true;
                _convertedNumber.Append(GetUaFromZeroToNine(enteredNumber[0]));
                if (enteredNumber[0] == '1')
                {
                    _convertedNumber.Append(_uaStringNumbers[49]);
                }
                else if (enteredNumber[0] == '2' || enteredNumber[0] == '3' || enteredNumber[0] == '4')
                {
                    _convertedNumber.Append(_uaStringNumbers[40]);
                }
                else
                {
                    _convertedNumber.Append(_uaStringNumbers[50]);
                }
                enteredNumber.Remove(0, 1);
            }

            if (enteredNumber.Length == 3)
            {
                _convertedNumber.Append(GetUaHundreds(enteredNumber[0]));
                enteredNumber.Remove(0, 1);
            }
            if (enteredNumber.Length == 2)
            {
                if (enteredNumber[0] == '1')
                {
                    _convertedNumber.Append(GetUaAfterNine(enteredNumber[1]));

                    _convertedNumber.Append("гривень ");

                    enteredNumber.Remove(0, 2);
                }
                else
                {
                    _convertedNumber.Append(GetUaTens(enteredNumber[0]));
                    enteredNumber.Remove(0, 1);
                }
            }
            if (enteredNumber.Length == 1)
            {
                _isAppendingBeforeMilion = true;
                _convertedNumber.Append(GetUaFromZeroToNine(enteredNumber[0]));
                if (enteredNumber[0] == '1')
                {                    
                    _convertedNumber.Append("гривня ");
                }
                else if (enteredNumber[0] == '2' || enteredNumber[0] == '3' || enteredNumber[0] == '4')
                {
                    _convertedNumber.Append("гривні ");
                }
                else
                {
                    _convertedNumber.Append("гривень ");
                }
            }
          
            if (isDotExist == true)
            {
                _convertedNumber.Append(_valueAfterDot.ToString());
            }
            return _convertedNumber.ToString();
        }

        #region UaConverterSwitchCase
        private string GetUaFromZeroToNine(char number)
        {
            switch (number)
            {
                case '0':
                    {
                        if (_isOneNumber == true)
                        {
                            return _uaStringNumbers[0];
                        }
                        else
                        {
                            return "";
                        }
                    }

                case '1':
                    {
                        if (_isAppendingBeforeMilion == true)
                        {
                            return _uaStringNumbers[45];
                        }
                        else
                        {
                            return _uaStringNumbers[1];
                        }                       
                    }

                case '2':
                    {
                        if (_isAppendingBeforeMilion == true)
                        {
                            return _uaStringNumbers[46];
                        }
                        else
                        {
                            return _uaStringNumbers[2];
                        }                       
                    }

                case '3':
                    {
                        return _uaStringNumbers[3];
                    }

                case '4':
                    {
                        return _uaStringNumbers[4];
                    }

                case '5':
                    {
                        return _uaStringNumbers[5];
                    }

                case '6':
                    {
                        return _uaStringNumbers[6];
                    }

                case '7':
                    {
                        return _uaStringNumbers[7];
                    }
                case '8':
                    {
                        return _uaStringNumbers[8];
                    }
                case '9':
                    {
                        return _uaStringNumbers[9];
                    }
            }
            return "";
        }

        private string GetUaAfterNine(char number)
        {
            switch (number)
            {
                case '0':
                    {
                        return _uaStringNumbers[10];
                    }
                case '1':
                    {
                        return _uaStringNumbers[11];
                    }

                case '2':
                    {
                        return _uaStringNumbers[12];
                    }

                case '3':
                    {
                        return _uaStringNumbers[13];
                    }

                case '4':
                    {
                        return _uaStringNumbers[14];
                    }

                case '5':
                    {
                        return _uaStringNumbers[15];
                    }

                case '6':
                    {
                        return _uaStringNumbers[16];
                    }

                case '7':
                    {
                        return _uaStringNumbers[17];
                    }
                case '8':
                    {
                        return _uaStringNumbers[18];
                    }
                case '9':
                    {
                        return _uaStringNumbers[19];
                    }
            }
            return "";
        }

        private string GetUaTens(char number)
        {
            switch (number)
            {
                case '1':
                    {
                        return _uaStringNumbers[10];
                    }
                case '2':
                    {
                        return _uaStringNumbers[20];
                    }

                case '3':
                    {
                        return _uaStringNumbers[21];
                    }

                case '4':
                    {
                        return _uaStringNumbers[22];
                    }

                case '5':
                    {
                        return _uaStringNumbers[23];
                    }

                case '6':
                    {
                        return _uaStringNumbers[24];
                    }

                case '7':
                    {
                        return _uaStringNumbers[25];
                    }
                case '8':
                    {
                        return _uaStringNumbers[26];
                    }
                case '9':
                    {
                        return _uaStringNumbers[27];
                    }
            }
            return "";
        }

        private string GetUaHundreds(char number)
        {
            switch (number)
            {
                case '1':
                    {
                        return _uaStringNumbers[28];
                    }

                case '2':
                    {
                        return _uaStringNumbers[29];
                    }

                case '3':
                    {
                        return _uaStringNumbers[30];
                    }

                case '4':
                    {
                        return _uaStringNumbers[31];
                    }

                case '5':
                    {
                        return _uaStringNumbers[32];
                    }

                case '6':
                    {
                        return _uaStringNumbers[33];
                    }

                case '7':
                    {
                        return _uaStringNumbers[34];
                    }
                case '8':
                    {
                        return _uaStringNumbers[35];
                    }
                case '9':
                    {
                        return _uaStringNumbers[36];
                    }                 
            }
            return "";
        }
        #endregion
    }
}
