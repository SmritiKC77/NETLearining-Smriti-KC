using System;


Console.WriteLine("I am main");
DataTypes dt = new();
dt.Learn();
Methods m = new();
m.Greet("Hi");

var hightst = m.GetMax(3.2,5.6,7.8);
Generics g = new();
g.Display<string>("Smriti KC");
Student Smriti = new Student(); // new keyword banauda constructor khojxa ; by defauult kunia pani class sanga constructor hunxa
Student Iliya = new Student("Iliya Fathma",04);

Smriti.RollNumber = 22; // Assigned
Iliya.RollNumber = 222;  // not assigned
// Smriti.Dob= DateTime.Now;
CSStudent rekha = new("Rekha Aryal", 24,"Hospital Management System");
rekha.DisplayInfo();
var sapana = new CyberSecurityStudent("Sapana Shrestha",11, "HMS","RedHat");// object banako
sapana.DisplayInfo();