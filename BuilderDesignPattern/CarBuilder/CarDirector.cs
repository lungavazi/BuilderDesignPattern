namespace BuilderDesignPattern.CarBuilder
{
    public  class CarDirector
    {
        public void construct(IBuilder ibuilder)
        {
            ibuilder.setMake();
            ibuilder.setModel();
            ibuilder.setEngine();
            ibuilder.setSeats();
            ibuilder.setColor();
        }
    }
}
