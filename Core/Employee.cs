using System;

class Employee
{
    private string fullName;
    private DateTime birthDate;
    private string phoneNumber;
    private string workEmail;
    private string position;
    private string jobDescription;

    
    public Employee(string fullName, DateTime birthDate, string phoneNumber, string workEmail, string position, string jobDescription)
    {
        this.fullName = fullName;
        this.birthDate = birthDate;
        this.phoneNumber = phoneNumber;
        this.workEmail = workEmail;
        this.position = position;
        this.jobDescription = jobDescription;
    }

    
    public void InputData()
    {
        
        Console.WriteLine("Введіть дані співробітника:");
        Console.Write("ПІБ: ");
        fullName = Console.ReadLine();
        Console.Write("Дата народження (рррр-мм-дд): ");
        birthDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Контактний телефон: ");
        phoneNumber = Console.ReadLine();
        Console.Write("Робочий email: ");
        workEmail = Console.ReadLine();
        Console.Write("Посада: ");
        position = Console.ReadLine();
        Console.Write("Опис службових обов’язків: ");
        jobDescription = Console.ReadLine();
    }

    public void DisplayData()
    {
       
        Console.WriteLine($"ПІБ: {fullName}");
        Console.WriteLine($"Дата народження: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Контактний телефон: {phoneNumber}");
        Console.WriteLine($"Робочий email: {workEmail}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Опис службових обов’язків: {jobDescription}");
    }

    
    public string GetFullName()
    {
        return fullName;
    }

    public void SetFullName(string value)
    {
        fullName = value;
    }

    
}
