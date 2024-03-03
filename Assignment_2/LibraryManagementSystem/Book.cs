using System;

public class Book : LibraryItem
{
    public string Author { get; set; }

    public Book(string title, string author, int year) : base(title, year)
    {
        Author = author;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author: {Author}");
    }
}
