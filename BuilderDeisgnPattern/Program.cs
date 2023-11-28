

//IBuilder    (abstraction design patterin)
interface IBuilder
{
    void reset();
    void setSeats(int number);
    void setEngine(string engine);
    void setTripComputer();
    void setGPS();
    ICar GetResult();

}

//Icar (abstraction design pattern)
interface ICar
{

}


//implements ICar
class Car:ICar
{
    public int seats { get; set; }
    public string engine { get; set; }
    public bool tripComputer { get; set; }
    public bool GPS { get; set; }

}

class Manual : ICar
{
    public int seats { get; set; }
    public string engine { get; set; }
    public bool tripComputer { get; set; }
    public bool GPS { get; set; }

}


//implemens IBuilder
class CarBuilder : IBuilder
{
    private Car car = new();

    public ICar GetResult()
    {
        return car;
    }

    public void reset()
    {
        car = new();
    }

    public void setEngine(string engine)
    {
        car.engine = engine;
    }

    public void setGPS()
    {
        car.GPS = true;
    }

    public void setSeats(int number)
    {
        car.seats = number;
    }

    public void setTripComputer()
    {
        car.tripComputer = true;
    }
}

class ManualBuilder : IBuilder
{
    private Manual manual = new();

    public ICar GetResult()
    {
        return manual;
    }

    public void reset()
    {
        manual = new();
    }

    public void setEngine(string engine)
    {
        manual.engine = engine;
    }

    public void setGPS()
    {
        manual.GPS = true;
    }

    public void setSeats(int number)
    {
        manual.seats = number;
    }

    public void setTripComputer()
    {
        manual.tripComputer = true;
    }
}



