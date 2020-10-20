using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Alight.Mew.Sparschwein.Test2
{
    class Program
    {
        public static List<Account> accounts = new List<Account>();

        public static void CreateNewAccount()
        {
            Account newAccount = new Account();
            Console.WriteLine("Wie soll Ihr neues Sparschwein heißen?");
            newAccount.Name = Console.ReadLine();
            

            accounts.Add(newAccount);

        }

        public static void PrintAccount(Account newAccount)
        {
            Console.WriteLine(newAccount.Name);

            Console.ReadKey();
        }

        public static void ListofAccounts(Account newAccount)
        {
            Console.WriteLine("Bitte geben Sie den Namen Ihres Sparschweins ein.");     
            string Name = Console.ReadLine();                                                          
            Account myAccount = accounts.FirstOrDefault(x => x.Name.ToLower() == Name.ToLower()); 

            if (myAccount == null)                                                                             
            {
                Console.WriteLine("Leider hat Ihre Eingabe kein Ergebnis.");                                
                Console.WriteLine("Bitte drücken Sie eine beliebige Taste ...");
                Console.ReadKey();
                return;                                                                                     
            }

            Console.WriteLine("Wollen Sie Änderungen im angegebenen Sparschwein vornehmen? (Y/N)");    
            Console.WriteLine("**************************************************************************");
            PrintAccount(myAccount);                                                                               

            if (Console.ReadKey().Key == ConsoleKey.Y)                                                          
            {
                selectAccount(myAccount);
            }
            else
            {
                return;
            }
        }

        static void selectAccount(Account myAccount)
        {
            string commandOfSelect = "";
            while (commandOfSelect != "return")
            {
                Console.Clear();
                Console.WriteLine("Einzahlen        (e)");
                Console.WriteLine("Auszahlen        (a)");
                Console.WriteLine("Kontostand       (k)");
                commandOfSelect = Console.ReadLine().ToLower();
                switch (commandOfSelect)
                {
                    case "e":
                        
                        break;
                    case "w":
                        //MakeWithdraw();
                        break;
                    case "k":
                        //AccountBalance();
                        break;
                }
            }
        }

        

    
        

        static void Main(string[] args)
        {
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Erstellen Sie ein neues Sparschwein        (e)");
                Console.WriteLine("Wählen aus den vorhandenen Sparschweinen   (w)");
                command = Console.ReadLine().ToLower();
                switch(command)
                {
                    case "e":
                        CreateNewAccount();
                        break;
                    case "w":
                        ListofAccounts();
                        break;

                        
                }  
            }
        }
    }
}
