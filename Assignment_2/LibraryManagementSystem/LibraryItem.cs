using System;

public class LibraryItem
{
    public string Title { get; set; }
    public int Year { get; set; }

    public LibraryItem(string title, int year)
    {
        Title = title;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Year: {Year}");
    }
}
