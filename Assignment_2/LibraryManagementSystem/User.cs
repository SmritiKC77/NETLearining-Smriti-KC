using System;

public class User : LibraryItem
{
    public int UserId { get; set; }

    public User(string name, int userId) : base(name, 0) // Using title for name, and year for UserId
    {
        UserId = userId;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"User Name: {Title}");
        Console.WriteLine($"User ID: {UserId}");
    }
}
