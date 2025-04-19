namespace BuilderDesignPattern.CarBuilder
{
    public interface IBuilder
    {
        void setModel();
        void setMake();
        void setSeats();
        void setEngine();
        void setColor();
        void reset();
        Car build();
    }
}
