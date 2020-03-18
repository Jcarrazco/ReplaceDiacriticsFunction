using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDiacritics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tecle una letra");
            string texto = Console.ReadLine().ToString();

            if (CheckForDiacritics(texto))
            {
                Console.WriteLine("Es diacritico");
            }
            else
            {
                Console.WriteLine("No es diacritico");
            }
            Console.ReadKey();
        }

        public static bool CheckForDiacritics(string text)
        {
            string[] character = { "á", "é", "í", "ó", "ú", "ñ" };

            for (int count = 0; count < character.Length; count++)
            {
                if(text.IndexOf(character[count], StringComparison.CurrentCultureIgnoreCase) > -1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
