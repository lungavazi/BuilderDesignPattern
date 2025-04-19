namespace BuilderDesignPattern.CarBuilder
{
    public class VWCarBuilder : IBuilder
    {
        private Car car = new Car();

        public Car build()
        {
            return car;
        }
        public void reset()
        {
            this.car = new Car();
        }
        public void setEngine()
        {
            this.car.setEngineType("1.4 L");
            //return this;
        }
        public void setMake()
        {
            this.car.setMake("Polo Vivo TrendLine");
        }

        public void setColor()
        {
            this.car.setColour("Silver Grey");
        }
        public void setModel()
        {
            this.car.setModel("2019");
        }

        public void setSeats()
        {
            this.car.setSeats(5);
        }
    }
}
