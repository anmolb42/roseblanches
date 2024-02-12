using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kk
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("How much did you receive money ($)? ");
            double moneyReceived = Convert.ToDouble(Console.ReadLine());

            double booksAndSupplies = moneyReceived * 0.75;
            double remainingMoney = moneyReceived - booksAndSupplies;

            double dividedMoney = remainingMoney / 3;

            double coffee = (dividedMoney / 2);//dividing by 2 because cost of coffee is 2 dollars
            double change1 = (dividedMoney % 2);//collecting change for the white roses

            double computer = (dividedMoney / 4);//cost of computer is 4 dollars
            double change2 = (dividedMoney % 4);

            double subway = (dividedMoney / 3);//cost of tickets is 3 dollars
            double change3 = (dividedMoney % 3);

            Console.WriteLine("Book and Supplies: " + booksAndSupplies + " $");
            Console.WriteLine("You can then buy: ");
         
            // Math.floor is added to round off the values.
            //If we add it above while dividing then it will affect output.//
            
            Console.WriteLine(Math.Floor(coffee) + " coffees");
            Console.WriteLine(Math.Floor(computer) + " Flash Computer Numbers");
            Console.WriteLine(Math.Floor(subway) + " Subway Tickets");
            Console.WriteLine("and you will have " + Math.Floor(change1 + change2 + change3) + " dollars for the white roses.");


            Console.Read();
        }
    }

}
