using System;

namespace NumericValuesToString_AntonYaniuk
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            LangSelectNumbValidation program = new LangSelectNumbValidation();
            bool isLanguageChosen = program.ChooseLanguage(); 

            if (isLanguageChosen == true)
            {
                program.LanguagePackInitialise();
                program.GetNumberFromUser();
            }
        }
    } 
}
