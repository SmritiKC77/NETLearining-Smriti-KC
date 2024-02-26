using System;

class Student
{
   //Default COnstructor 
    public Student() // methos without any return type
    {

    }
   // prameterized Constructor
    public Student(string n, byte rn)
    {
name = n;
rollNumber= rn;
    }
    string name; // class vitra ko field haru ho 
    byte rollNumber;// property is nothing but a field but we use it in a controllled manner
    public byte RollNumber
    {
get{
    return rollNumber; // get, set and value is a keyword(in blue)
}
set
{
    if(value<=100)
    {
        rollNumber= value;
    }
}
    }
   // property ko intension nai outside of class access garna sakos
    public string Address{get; set;} // auto implemented property
    DateTime dob;
    public void DisplayInfo()
    {
        Console.WriteLine($"Student Name:{name}");
        Console.WriteLine($"Student Roll Number:{rollNumber}");
        
    }
}