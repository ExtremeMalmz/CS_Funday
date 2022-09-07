//Eric Malmström
using System;
using System.IO;
using System.Text;

namespace TicketSpace
{
    class TicketSeller
    {
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;

        public TicketSeller()
        //constructor
        {
            Console.WriteLine("Welcome to KID'S FAIR!\nChildren get always a 75% discount!");
            this.name = "";
            this.price = 100;
            this.numOfAdults = 0;
            this.numOfChildren = 0;
            this.amountToPay = 0;
        }

        public void set_name()
        //sets name to a string
        {
            Console.WriteLine("\nYour name please:");
            this.name = Console.ReadLine();
        }

        public void set_numOfAdults()
        //sets the numOfAdults to an integer
        {
            Console.WriteLine("Number of adults:");
            this.numOfAdults = Convert.ToInt32(Console.ReadLine());
        }

        public void set_numOfChildren()
        //sets the numOfAdults to an integer
        {
            Console.WriteLine("Number of children:");
            this.numOfChildren = Convert.ToInt32(Console.ReadLine());
        }

        private int calculateTotalCost()
        //calculates cost of admission. Adults being 100.00 and children being 25.00
        {
            int adultSum = 0, childrenSum = 0;

            adultSum = this.numOfAdults * 100;
            childrenSum = this.numOfChildren * 25;
            return childrenSum+adultSum;
        }

        public void print_reciept()
        //prints a reciept based on the amount of children and adults
        {
            int totalSum = calculateTotalCost();
            Console.WriteLine(" +++ Your Reciept +++\n +++ Amount to pay = " + totalSum + ".00");
            Console.WriteLine(" +++ Thank you " + this.name + " and please come back! +++");
        }
    }
}