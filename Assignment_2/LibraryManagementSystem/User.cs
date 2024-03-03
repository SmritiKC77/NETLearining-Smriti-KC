// User.cs
using System;

public class User
{
    public string Name { get; set; }
    public int UserId { get; set; }

    public User(string name, int userId)
    {
        Name = name;
        UserId = userId;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"User Name: {Name}");
        Console.WriteLine($"User ID: {UserId}");
    }
}
