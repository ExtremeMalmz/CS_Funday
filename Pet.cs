//using namespace std
using System;
using System.IO;
using System.Text;

namespace Petspace
{
    class Pets
    {
        private String name;
        private int age;
        private bool? isFemale;
        public Pets()
        //constructor
        {
            Console.WriteLine("Greetings from the MyPets class!");
            this.name = "Harry";
            this.age = 12345;
            this.isFemale = null;
        }

        public void set_name()
        //sets the name to a string
        {
            Console.Write("\nWhat is the name of your pet? ");
            this.name = Console.ReadLine();
        }
       
        public void set_age()
        //sets the age to a whole number
        {
            Console.Write("What is your " + this.name + "'s age? ");
            this.age = Convert.ToInt32(Console.ReadLine());
        }

        public void set_isFemale()
        //sets the isFemale to a true or false
        {
            Console.Write("Is your pet a female (y/n) ");
            string choice = Console.ReadLine();

            if(choice == "y")
            {
                this.isFemale = true;
            }
            else
            {
                this.isFemale = false;
            }
            //this.isFemale = Convert.ToBoolean(Console.ReadLine());
        }

        public void printOut()
        {
            //prints everything out 
            //string gender is determined by the isFemale 
            string gender = "";

            if(isFemale == true)
            {
                gender = "girl";
            }
            else
            {
                gender = "boy";
            }
            
            Console.WriteLine("\n++++++++++++++++++++++++++");
            Console.WriteLine("Name: " + name + " Age: " + age + "\n" + name + " is a good " + gender + "!");
            Console.WriteLine("++++++++++++++++++++++++++");
        }
    }
}