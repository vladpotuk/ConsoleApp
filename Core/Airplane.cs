using System;

class Airplane
{
    private string airplaneName;
    private string manufacturerName;
    private int manufacturingYear;
    private string airplaneType;

    
    public Airplane(string airplaneName, string manufacturerName, int manufacturingYear, string airplaneType)
    {
        this.airplaneName = airplaneName;
        this.manufacturerName = manufacturerName;
        this.manufacturingYear = manufacturingYear;
        this.airplaneType = airplaneType;
    }

   
    public void InputData()
    {
        
        Console.WriteLine("Введіть дані літака:");
        Console.Write("Назва літака: ");
        airplaneName = Console.ReadLine();
        Console.Write("Назва виробника: ");
        manufacturerName = Console.ReadLine();
        Console.Write("Рік випуску: ");
        manufacturingYear = int.Parse(Console.ReadLine());
        Console.Write("Тип літака: ");
        airplaneType = Console.ReadLine();
    }

    public void DisplayData()
    {
        
        Console.WriteLine($"Назва літака: {airplaneName}");
        Console.WriteLine($"Назва виробника: {manufacturerName}");
        Console.WriteLine($"Рік випуску: {manufacturingYear}");
        Console.WriteLine($"Тип літака: {airplaneType}");
    }

    
    public string GetAirplaneName()
    {
        return airplaneName;
    }

    public void SetAirplaneName(string value)
    {
        airplaneName = value;
    }

    
}
