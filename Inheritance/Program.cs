using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class


            /* DONE Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var robin = new Bird();
            robin.Name = "robin";
            robin.Wingspan = "10";
            robin.BeakColor = "orange";
            robin.Home = "tree";
            robin.Food = "worms";
            
            robin.AboutBirds();

            Console.WriteLine("----------------------------------------");

            /* DONE Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            
            var gartersnake = new Reptile();
            gartersnake.Name = "garter snake";
            gartersnake.Length = "2 to 4 feet";
            gartersnake.LikesWater = "No";
            gartersnake.IsVenomous = "No";
            gartersnake.LivesInMichigan = "Yes";
            
            gartersnake.AboutReptiles();
        }
    }
}
