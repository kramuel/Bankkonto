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

                //Print Hej välkommen till din bank, #skapa konto, #skriv in ditt bankkonto 
                PrintMenu();

                //läs in input func /quitmetod
                UserInput(0, 3);

                //skapa konto metod

                ////#visa saldo, #sätt in /ta ut pengar #gå ut för se startmeny

                //

            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("**Välkommen til BANKEN**");
            Console.WriteLine("1:  Skapa nytt bankkonto.");
            Console.WriteLine("2:  Logga in på ditt konto.");
            Console.WriteLine("0:  Avsluta BANKEN.");

        }

        static int UserInput(int start, int count)
        {

            var menuChoice = Enumerable.Range(start, count);
            Console.Write("menuChoice = ");
            foreach (int i in menuChoice)
                Console.Write(" {0} ",i);



            int userInput = int.Parse(Console.ReadLine());


            //input can only be 0-4
            while (!menuChoice.Contains(userInput))
            {
                //wrong input loop
                Console.WriteLine("wrong input try again: ");
                userInput = int.Parse(Console.ReadLine());
            }
            return userInput;
            

        }
    }
}
