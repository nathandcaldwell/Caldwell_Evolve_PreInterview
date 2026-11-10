using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caldwell_Evolve_PreInterview
{
    internal class Parking
    {
        internal class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Tires { get; set; }
            public double Length { get; set; }
            public double Weight { get; set; }
            public int PassengerMax { get; set; }
            public Vehicle(string make, string model, int tires, double length, double weight, int passengerMax)
            {
                Make = make;
                Model = model;
                Tires = tires;
                Length = length;
                Weight = weight;
                PassengerMax = passengerMax;
            }
        }

        internal class Lot
        {
            // List of available spaces in lot
            // Functions to fill spaces and remove vehicles from spaces
            // Functions to check if a space is full
        }

        internal class Garage : Lot
        {
            // extra list of compact spaces
            // Extra function to determine if vahicle is a Bus (probably by length and width)
            // parking function to check car weight, and if below 1500, check for compact space first before parking in regular space
        }

        internal class Car : Vehicle
        {
            public Car(string make, string model, int tires, double length, double weight, int passengerMax)
                : base(make, model, tires, length, weight, passengerMax)
            {
            }
        }

        internal class Motorcycle : Vehicle
        {
            public Motorcycle(string make, string model, int tires, double length, double weight, int passengerMax)
                : base(make, model, tires, length, weight, passengerMax)
            {
            }
        }

        internal class Bus : Vehicle
        {
            public Bus(string make, string model, int tires, double length, double weight, int passengerMax)
                : base(make, model, tires, length, weight, passengerMax)
            {
            }
        }
    }
}
