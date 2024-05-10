using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   
        Course course1 = new Course();
        course1._courseCode = "CSE 210";
        course1._courseName = "Prog. with Classess";
        course1._creditHours = 2;
        course1._color = "Green";
        course1.Display();       
    } 
} 
