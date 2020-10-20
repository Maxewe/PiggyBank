using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alight.Mew.Sparschwein
{
    class Program
    {

        

       
        public static List<moneyBox> owner = new List<moneyBox>();

        

        public static void addMoney()
        {
            moneyBox owner1 = new moneyBox(001, 002, 005, 010, 020, 050, 100, 200);
            Console.WriteLine("Wie viele ein Cent Münzen möchten Sie einzahlen?");
            owner1.einCent = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Wie viele zwei Cent Münzen möchten Sie einzahlen?");
            owner1.zweiCent = Convert.ToDecimal(Console.ReadLine()) * 002;
            Console.WriteLine("Wie viele fünf Cent Münzen möchten Sie einzahlen?");
            owner1.fünfCent = Convert.ToDecimal(Console.ReadLine()) * 005;
            Console.WriteLine("Wie viele zehn Cent Münzen möchten Sie einzahlen?");
            owner1.zehnCent = Convert.ToDecimal(Console.ReadLine()) * 010;
            Console.WriteLine("Wie viele zwanzig Cent Münzen möchten Sie einzahlen?");
            owner1.zwanzigCent = Convert.ToDecimal(Console.ReadLine()) * 020;
            Console.WriteLine("Wie viele fünfzig Cent Münzen möchten Sie einzahlen?");
            owner1.fünfzigCent = Convert.ToDecimal(Console.ReadLine()) * 050;
            Console.WriteLine("Wie viele ein Euro Münzen möchten Sie einzahlen?");
            owner1.einEuro = Convert.ToDecimal(Console.ReadLine()) * 100;
            Console.WriteLine("Wie viele zwei Euro Münzen möchten Sie einzahlen?");
            owner1.zweiEuro = Convert.ToDecimal(Console.ReadLine()) * 200;

            owner.Add(owner1);
        }

       

        public static void printMoney(moneyBox owner1)
        {
            

            Console.WriteLine("ein Cent Münzen:     " + owner1.einCent);
            Console.WriteLine("zwei Cent Münzen:    " + owner1.zweiCent);
            Console.WriteLine("fünf Cent Münzen:    " + owner1.fünfCent);
            Console.WriteLine("zehn Cent Münzen:    " + owner1.zehnCent);
            Console.WriteLine("zwanzig Cent Münzen: " + owner1.zwanzigCent);
            Console.WriteLine("fünfzig Cent Münzen: " + owner1.fünfzigCent);
            Console.WriteLine("ein Euro Münzen:     " + owner1.einEuro);
            Console.WriteLine("zwei Euro Münzen:    " + owner1.zweiEuro);
            Console.WriteLine("*****************************************");

            decimal sumOfMoney = owner1.einCent * 001 + owner1.zweiCent * 002 + owner1.fünfCent * 005 + owner1.zehnCent * 010 +
                            owner1.zwanzigCent * 020 + owner1.fünfzigCent * 050 + owner1.einEuro * 100 + owner1.zweiEuro * 200;

            Console.WriteLine("Inhalt des Sparschweins: " + sumOfMoney + " Euro");
            
        }

        public static void listOfMoney()
        {
            foreach (var owner1 in owner)
            {
                printMoney(owner1);                                                                   //Print-Befehl, wenn else-Anweisung wahr, dann Ausgabe der Kontakte aus der Liste allContacts in der Konsole 
            }
            Console.ReadKey();
        }
        /*
        public static void removeMoney()
        {
            double abheben = 0.00;

            Console.WriteLine("Wie viel Euro möchten Sie abheben?");
            abheben = Convert.ToDouble(Console.ReadLine());

            moneyBox owner1 = owner.FirstOrDefault(x => x.zweiEuro.ToString() == abheben.ToString());

            owner1.zweiEuro = abheben / 2.00;
            abheben = abheben % 2.00;
            
            owner1.einEuro = abheben / 1.00;
            abheben = abheben % 1.00;

            owner1.fünfzigCent = abheben / 0.50;
            abheben = abheben % 0.50;

            owner1.zwanzigCent = abheben / 0.20;
            abheben = abheben % 0.20;

            owner1.zehnCent = abheben / 0.10;
            abheben = abheben % 0.10;

            owner1.fünfCent = abheben / 0.05;
            abheben = abheben % 0.05;

            owner1.zweiCent = abheben / 0.02;
            abheben = abheben % 0.02;

            owner1.einCent = abheben / 0.01;
            abheben = abheben % 0.01;

            Console.WriteLine("ein Cent Münzen:     " + owner1.einCent);
            Console.WriteLine("zwei Cent Münzen:    " + owner1.zweiCent);
            Console.WriteLine("fünf Cent Münzen:    " + owner1.fünfCent);
            Console.WriteLine("zehn Cent Münzen:    " + owner1.zehnCent);
            Console.WriteLine("zwanzig Cent Münzen: " + owner1.zwanzigCent);
            Console.WriteLine("fünfzig Cent Münzen: " + owner1.fünfzigCent);
            Console.WriteLine("ein Euro Münzen:     " + owner1.einEuro);
            Console.WriteLine("zwei Euro Münzen:    " + owner1.zweiEuro);
            Console.WriteLine("*****************************************");

            owner.Remove(owner1);
        }
      */

        

        static void Main(string[] args)
        {

            string command = "";                                                                            //Variablen-Zuweisung für die einzelnen Kommandos im Hauptmenü
            while (command != "exit")                                                                       //while-Anweisung, solange nicht exit eingegeben wird, wird Main-Methode weiter ausgeführt
            {
                Console.Clear();
                Console.WriteLine("Willkommen zu Ihrem persönlichen Sparschwein!");                        //Konsolen Textausgabe für die Darstellung des Menüs
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Bitte wählen Sie in folgender Auswahl Ihre weiteren Schritte:");
                Console.WriteLine("Inhalt" + "    (i)");
                Console.WriteLine("Einzahlen" + "   (e)");
                Console.WriteLine("Auszahlen" + "     (a)");
                Console.WriteLine("Zum Beenden des Programms geben Sie bitte 'Exit' ein.");
                command = Console.ReadLine().ToLower();
                switch (command)                                                                            //switch-Anweisung für den Fall der Eingabe eines Bestimmten Wertes durch den Benutzer in der Konsole
                {
                    case "e":                                                                               //Zuweisung der case-Bezeichnung für den Wert 'e' -> Aufruf der Methode AddContact
                        addMoney();
                        break;/*                        
                    case "a":                                                                               //Zuweisung der case-Bezeichnung für den Wert 'l' -> Aufruf der Methode RemoveContact
                        removeMoney();
                        break;                        
                    */case "i":                                                                               //Zuweisung der case-Bezeichnung für den Wert 'a' -> Aufruf der Methode ListContact zum Anzeigen der allContacts Liste in der Konsole
                        listOfMoney();
                        break;

                }
            }
        }
    }
}
