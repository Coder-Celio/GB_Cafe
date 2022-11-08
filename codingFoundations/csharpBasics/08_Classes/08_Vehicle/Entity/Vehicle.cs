public class Vehicle
{
    public Vehicle()
    {
        L_Indicator = new Indicator();
        R_Indicator = new Indicator();
    }
    public string? Make {get;set;}
    public string? Model {get;set;}
    public double? Milage {get;set;}
    public VehicleType VehicleType {get;set;}
    
    //So IsRunning can only be changed by a method that lives in this class
    public bool IsRunning {get; private set;}

    //lets make some methods
    public void TurnOn()
    {
        IsRunning = true;
        System.Console.WriteLine("The vehicle is TURNED ON!");
    }

    public void TurnOff()
    {
        IsRunning = false;
        System.Console.WriteLine("You turned off the vehicle");
    }

    //Sometimes we may want to associate a lass with another class
    //All vehicles have indicators (so we think at the moment)
    
    public Indicator L_Indicator {get; set;} 
    public Indicator R_Indicator {get; set; }
    public void IndicateRight()
    {
        R_Indicator.TurnOn();
        L_Indicator.TurnOff();
        System.Console.WriteLine("Turning Left");
    }
    public void IndicateLeft()
    {
        L_Indicator.TurnOn();
        R_Indicator.TurnOff();
        System.Console.WriteLine("Turning Left");
    }

    public void TurnOnHazards()
    {
        L_Indicator.TurnOn();
        R_Indicator.TurnOn();
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(500);
            System.Console.WriteLine("HAZARDS");
        }
    }

    public void ClearIndicators()
    {
        L_Indicator.TurnOff();
        R_Indicator.TurnOff();
        System.Console.WriteLine("Cleared Indicators!!!");
        Console.ReadKey();
        Console.Clear();
    }
}