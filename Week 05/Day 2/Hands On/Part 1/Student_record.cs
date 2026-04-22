using System;
using System.Collections.Generic;

public record Student(int RollNo, string Name, string Course, int Marks);

public class StudentApp
{
    public void Run()
    {
        List<Student> students = new List<Student>();

        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Roll Number: ");
            int roll = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            students.Add(new Student(roll, name, course, marks));
            Console.WriteLine();
        }

        Console.WriteLine("Student Records:");
        foreach (var s in students)
        {
            Console.WriteLine($"Roll No: {s.RollNo} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
        }

        Console.Write("\nSearch Roll Number: ");
        int search = int.Parse(Console.ReadLine());

        bool found = false;

        foreach (var s in students)
        {
            if (s.RollNo == search)
            {
                Console.WriteLine("\nStudent Found:");
                Console.WriteLine($"Roll No: {s.RollNo} | Name: {s.Name} | Course: {s.Course} | Marks: {s.Marks}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Student not found");
        }
    }
}