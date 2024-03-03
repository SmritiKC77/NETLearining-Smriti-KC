// Library.cs
using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books;
    private List<User> users;

    public Library()
    {
        books = new List<Book>();
        users = new List<User>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void RemoveUser(User user)
    {
        users.Remove(user);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books available in the library:");
        foreach (var book in books)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }
    }

    public void DisplayUsers()
    {
        Console.WriteLine("Users registered in the library:");
        foreach (var user in users)
        {
            user.DisplayInfo();
            Console.WriteLine();
        }
    }
}
