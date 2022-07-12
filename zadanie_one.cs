using System;

class Programm
{
    static void Main(string[] args)
    {
        double firstValue, secondValue;
        Console.WriteLine("Ввдите первое число");
        firstValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Ввдите 2 число");
        secondValue = double.Parse(Console.ReadLine());
        double result = (firstValue + secondValue) / 2;
        Console.WriteLine(result);
    }

}