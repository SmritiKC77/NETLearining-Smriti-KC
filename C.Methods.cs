using System;
class Methods
{
   public void Greet()
    {
        Console.WriteLine("Hey, there!");

    }
    public void Greet(string greeting)
    {
        Console.WriteLine($"{greeting},there!"); // String interpolation
    }
    public CalculateBMI(float weightInKg,float heightInFt)
    {
        float heightInM = heightInFt = 0.3048f;
        var bmi = weightInKg/(heightInFt* heightInFt);
        return bmi;

    }
}