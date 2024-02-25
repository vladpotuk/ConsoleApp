using System;

class Program
{
    static void Main()
    {
        // Завдання 5 - Співробітник
        Employee employee = new Employee("", DateTime.MinValue, "", "", "", "");
        employee.InputData();
        employee.DisplayData();

        // Завдання 6 - Літак
        Airplane airplane = new Airplane("", "", 0, "");
        airplane.InputData();
        airplane.DisplayData();

        // Завдання 7 - Матриця
        Matrix matrix = new Matrix(3, 3);
        matrix.InputData();
        matrix.DisplayData();

        int max = matrix.FindMax();
        int min = matrix.FindMin();
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Мінімум: {min}");
    }
}

