using System;

class Program
{
    static void Main(string[] args)
    {
        Course course1 = new Course();
        course1._courseCode = "CSE210";
        course1._courseName = "Programming with Classes";
        course1._creditHours = 2;
        course1._color = "green";

        course1.Display();
    }
}