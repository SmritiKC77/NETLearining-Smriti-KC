// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Adding books
        Book book1 = new Book("Hands on Machine Learning", "Geron Aurelien", 2017);
        Book book2 = new Book("Digital Logic", "Morris Mano", 1979);
        library.AddBook(book1);
        library.AddBook(book2);

        // Adding users
        User user1 = new User("Smriti KC", 1001);
        User user2 = new User("Iliya Fathma", 1002);
        library.AddUser(user1);
        library.AddUser(user2);

        // Display books and users
        library.DisplayBooks();
        library.DisplayUsers();
    }
}

