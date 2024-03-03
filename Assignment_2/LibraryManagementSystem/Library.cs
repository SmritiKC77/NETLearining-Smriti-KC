using System;
using System.Collections.Generic;

public class Library
{
    private List<LibraryItem> items;

    public Library()
    {
        items = new List<LibraryItem>();
    }

    public void AddItem(LibraryItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(LibraryItem item)
    {
        items.Remove(item);
    }

    public void DisplayItems()
    {
        Console.WriteLine("Items available in the library:");
        foreach (var item in items)
        {
            item.DisplayInfo();
            Console.WriteLine();
        }
    }
}
