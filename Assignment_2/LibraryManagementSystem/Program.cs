using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Adding books
        Book book1 = new Book("Hands on Machine Learning", "Geron Aurelien", 2017);
        Book book2 = new Book("Digital Logic", "Morris Mano", 1979);
        library.AddItem(book1); // Use AddItem instead of AddBook
        library.AddItem(book2); // Use AddItem instead of AddBook

        // Adding users
        User user1 = new User("Smriti KC", 1001);
        User user2 = new User("Iliya Fathma", 1002);
        library.AddItem(user1); // Use AddItem instead of AddUser
        library.AddItem(user2); // Use AddItem instead of AddUser

        // Display items (books and users)
        library.DisplayItems(); // Use DisplayItems to display all items
    }
}
