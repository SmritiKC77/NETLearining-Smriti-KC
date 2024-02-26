using System;

Console.WriteLine("Enter your Name:");
string fullName = Console.ReadLine();
string cfullName = fullName.ToUpper();

Console.WriteLine("Enter your Date of Birth (YYYY/MM/DD):");
string dobString = Console.ReadLine();
DateTime DOB = DateTime.Parse(dobString);

DateTime today = DateTime.Today;

TimeSpan age = today - DOB;
int totalDays = (int)age.TotalDays;

int years = totalDays / 365;
int months = (totalDays % 365) / 30;
int weeks = ((totalDays % 365) % 30) / 7;
int days = ((totalDays % 365) % 30) % 7;

Console.WriteLine($"Hello, {cfullName} Ji");

Console.WriteLine($"Your DOB: {DOB.ToString("dddd, dd MMMM yyyy")}.");

Console.WriteLine($"Age as of now: {years} years {months} months {weeks} weeks and {days} days old. \n");
