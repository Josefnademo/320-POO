public class Pasanger
{
    public string _name= "monkey";
    public bool _seat;
    public void Seat()
    {
      
        Console.WriteLine("im " + _name+"in the car");
    }
}

public class Engine
{
    public bool _work=true;
    public void Start()
    {
        if (_work==true)
        Console.WriteLine("im working(ENGINE)");
    }
}

public class Car
{
    private Engine _engine;
    private Pasanger _pasanger;

    private int places = 4;
    private string color = "red";


    public void Pasangers()
    {
        _pasanger = new Pasanger();

    }

    public void StartCar () 
    {
        _engine.Start();
        Console.WriteLine("Car is on");
    }
}