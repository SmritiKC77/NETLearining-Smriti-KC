using System;
class Generics 
{
    public T Display<T>(T value) // Type as a argument
    {
        Console.WriteLine($"value{value}");
        return value;

    }
}