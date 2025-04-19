using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.CarBuilder
{
    public class ToyotaCarBuilder : IBuilder
    {
        private Car _car = new Car();
        public void setEngine()
        {
            _car.setEngineType("V12");
        }
        public void setSeats()
        {
            _car.setSeats(5);
        }
        public void setModel()
        {
            _car.setModel("Toyota Hilux");
        }
        public void setMake()
        {
            _car.setMake("4 X 4 Rider");
        }
        public void reset()
        {
            _car = new Car();
        }
        public void setColor()
        {
            this._car.setColour("Blue");
        }
        public Car build()
        {
            return _car;
        }
    }
}
