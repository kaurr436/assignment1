﻿using Assignment_1;

class Program
{
    static void Main()
    {
        var student1 = StudentMethods.CreateStudent(1, StudentType.FullTime, "ramandeep", "kaur");
        var student2 = StudentMethods.CreateStudent(2, StudentType.FullTime, "aman", "kaur");
        var student3 = StudentMethods.CreateStudent(3, StudentType.PartTime, "Mandeep", "kaur");

        Console.WriteLine("Assignment One");

        StudentMethods.OutputStudent(student1);
        StudentMethods.OutputStudent(student2);
        StudentMethods.OutputStudent(student3);
    }
}