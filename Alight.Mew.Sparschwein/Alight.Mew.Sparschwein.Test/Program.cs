using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alight.Mew.Sparschwein.Test
{

    class Program
    {

        public static moneyBox vonMax = new moneyBox(2.00, 1.00, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01);

        public static void deposit()
        {
            Console.WriteLine("Bitte geben Sie die Anzahl der 1 Cent Münzen ein, die Sie einzahlen möchten:");
            vonMax.einCent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Anzahl der 2 Cent Münzen ein, die Sie einzahlen möchten:");
            vonMax.zweiCent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Anzahl der 5 Cent Münzen ein, die Sie einzahlen möchten:");
            vonMax.fünfCent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Anzahl der 10 Cent Münzen ein, die Sie einzahlen möchten:");
            vonMax.zehnCent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Anzahl der 20 Cent Münzen ein, die Sie einzahlen möchten:");
            vonMax.zwanzigCent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Anzahl der 50 Cent Münzen ein, die Sie einzahlen möchten:");
            vonMax.fünfzigCent = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Anzahl der 1 Euro Münzen ein, die Sie einzahlen möchten:");
            vonMax.einEuro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Anzahl der 1 Euro Münzen ein, die Sie einzahlen möchten:");
            vonMax.zweiEuro = Convert.ToDouble(Console.ReadLine());

        }

        static void Main(string[] args)
        {

        }
    }
}
