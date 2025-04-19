using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.CarBuilder
{
    public class Car
    {
        private string make;
        private string model;
        private int numberOfSeats;
        private string color;
        private string engineType;
        private string gpsSettings;
        private Boolean hasSunRoof;
        public void setMake(string make) {  this.make = make; }
        public void setModel(string model) { this.model = model;}
        public void setSeats(int noOfSeat) { this.numberOfSeats = noOfSeat;}
        public void setColour(string colour) 
        { this.color = colour;}
        public void setEngineType(string engineType) { this.engineType = engineType;}

        public void desiplayInfo()
        {
            Console.WriteLine($"Car make: {make}");
            Console.WriteLine($"Car model: {model}");
            Console.WriteLine($"Engine type: {engineType}");
            Console.WriteLine($"color: {color}");
            Console.WriteLine($"No of seats: {numberOfSeats}");
            Console.WriteLine($"Convertible: {hasSunRoof}");
            Console.WriteLine();
        }
    }
}
