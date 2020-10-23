using System;
using System.Collections.Generic;
using System.Linq;

namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Informationens som ska läsas in är namn, adress, telefonnummer och kontonummer. Informationen
            //ska lagras i variabler med lämpliga datatyper och namn.

            //Programmet ska visa en meny där användaren kan välja om hen vill sätta in eller ta ut pengar på
            //kontot.Hen ska även kunna välja att se saldot på kontot eller avsluta programmet.

            //Startmeny metod/loop
            while (true)
            {
                int choice;
                //Tuple acc = new Tuple<string, string, int, int> {;
                //var accounts = List<Tuple>;
                //Print Hej välkommen till din bank, #skapa konto, #skriv in ditt bankkonto 
                PrintStartMenu();

                //läs in input func /quitmetod
                choice = UserInput(3);

                if ( choice == 0) // breakar while loopen = quittar
                {
                    Console.WriteLine("Good bye, and good luck!!");
                    break;
                }
                else if ( choice == 1) // skapa konto
                {
                    CreateAccount();
                }
                else if (choice == 2)////#visa saldo, #sätt in /ta ut pengar #gå ut för se startmeny
                {
                    AccountMenu();
                }


            }
        }

        private static void AccountMenu()
        {
            throw new NotImplementedException();
        }

        private static void CreateAccount()
        {
            throw new NotImplementedException();
        }

        static void PrintStartMenu()
        {
            Console.WriteLine("**Welcome to the BANK**");
            Console.WriteLine("1:  Create new Account.");
            Console.WriteLine("2:  Sign in to your Account.");
            Console.WriteLine("0:  Exit the BANK.");

        }

        //takes in how many options u want, loops if wrong input
        //wrong input is anything except 0-optionsAmount (int)
        static int UserInput(int optionsAmount)
        {
            Console.WriteLine("Please enter number to chose(0 - {0}):  ", optionsAmount-1);
            int choice;
            var menuChoice = Enumerable.Range(0, optionsAmount);
            string userInput = Console.ReadLine();

            //input can only be an int
            while (!int.TryParse(userInput, out choice))
            {
                Console.SetCursorPosition(0, optionsAmount + 1);
                Console.WriteLine("That is not a number, please try again: ");
                userInput = Console.ReadLine();
            }
            //input can only be one of the options
            while (!menuChoice.Contains(choice))
            {

                Console.SetCursorPosition(0, optionsAmount + 1);
                Console.WriteLine("That is no option, try again:        ");
                userInput = Console.ReadLine();
                choice = int.Parse(userInput);
            }
            return choice;
        }
    }
}
