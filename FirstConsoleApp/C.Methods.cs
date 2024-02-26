using System;
using System.Linq;
class Methods
{
   public void Greet() => Console.WriteLine("hey, there!");

    public void Greet(string greeting)
    {
        Console.WriteLine($"{greeting},there!"); // String interpolation
    }
    public float  CalculateBMI(float weightInKg,float heightInFt)
    {
        var heightInM = heightInFt = 0.3048f;
        var bmi = weightInKg/(heightInFt* heightInFt);
        return bmi;

    }
    //variable number of arguments
    public double  GetMax(params double[] numbers) =>  numbers.Max(); // max is built in method
    public (int, int) GetMinMax(params int[] numbers)
    {
        var smallest= numbers.Min();
        var highest= numbers.Max();
        return(smallest, highest) ;// tuple

    }
}