using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           //Name each building and give them properties
           Building FiveOneTwoEigth = new Building("512 8th Avenue");
           FiveOneTwoEigth.Width = 700;
           FiveOneTwoEigth.Depth = 400;
           FiveOneTwoEigth.Stories = 10;
           FiveOneTwoEigth.Construct();
           FiveOneTwoEigth.Purchase("Jenn");

           Building OneOneThirteen = new Building("11 13th Avenue");
           OneOneThirteen.Width = 1100;
           OneOneThirteen.Depth = 1500;
           OneOneThirteen.Stories = 15;
           OneOneThirteen.Construct();
           OneOneThirteen.Purchase("April");
           

           Building TwelveTwelveTwelve = new Building("1212 12th Avenue");
           TwelveTwelveTwelve.Width = 1200;
           TwelveTwelveTwelve.Depth = 900;
           TwelveTwelveTwelve.Stories = 13;
           TwelveTwelveTwelve.Construct();
           TwelveTwelveTwelve.Purchase("Patti");
           

           Building OneTwoThirtyFour = new Building("12 34th Avenue");
           OneTwoThirtyFour.Width = 850;
           OneTwoThirtyFour.Depth = 1600;
           OneTwoThirtyFour.Stories = 22;
           OneTwoThirtyFour.Construct();
           OneTwoThirtyFour.Purchase("Jessica");


           Building TenNineEight = new Building("109 8th Avenue");
           TenNineEight.Width = 920;
           TenNineEight.Depth = 380;
           TenNineEight.Stories = 30;
           TenNineEight.Construct();
           TenNineEight.Purchase("Jamie");

            //Make a list of all the buildings
            List<Building> Buildings = new List<Building>()
            {
                FiveOneTwoEigth,
                OneOneThirteen,
                TwelveTwelveTwelve,
                OneTwoThirtyFour,
                TenNineEight
            };
            
            //Loop through the list and print desired information
            foreach (Building building in Buildings) {
                Console.WriteLine(building.Address);
                Console.WriteLine("---------------");
                Console.WriteLine($"Designed by {building.Designer}");
                Console.WriteLine($"Constructed on {building.ConstructedDate}");
                Console.WriteLine($"Owned by {building.Owner}");
                Console.WriteLine("{building.Volume} cubic meters of space");
                Console.WriteLine();
            }


        }
    }
}