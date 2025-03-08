using System;

namespace TravelTracker
{
    internal class Trip
    {
        // Fields to store trip details
        public string Destination;
        public int DistanceTraveled;
        public double TotalFuelCost;
        public double FuelConsumed;

        // Constructor
        public Trip()
        {
            Console.WriteLine("Trip details are as follows:");
        }

        // Method to display trip information
        public void DisplayDetails()
        {
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Distance Traveled: {DistanceTraveled} miles");
            Console.WriteLine($"Total Fuel Cost: ${TotalFuelCost}");
            Console.WriteLine($"Fuel Consumed: {FuelConsumed} gallons");
        }

        // Method to calculate and display fuel efficiency
        public void CalculateMilesPerGallon()
        {
            if (FuelConsumed > 0)
            {
                double milesPerGallon = DistanceTraveled / FuelConsumed;
                Console.WriteLine($"Miles per Gallon: {milesPerGallon:F2}");
            }
            else
            {
                Console.WriteLine("Fuel consumed must be greater than zero to calculate MPG.");
            }
        }

        // Method to calculate and display cost per mile
        public void CalculateCostPerMile()
        {
            if (DistanceTraveled > 0)
            {
                double costPerMile = TotalFuelCost / DistanceTraveled;
                Console.WriteLine($"Cost per Mile: ${costPerMile:F2}");
            }
            else
            {
                Console.WriteLine("Distance traveled must be greater than zero to calculate cost per mile.");
            }
        }
    }
}