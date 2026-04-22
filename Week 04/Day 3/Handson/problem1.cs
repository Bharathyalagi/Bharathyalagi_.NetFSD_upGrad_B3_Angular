using System;
class Problem1
{
    static void Main()
    {
        Console.Write("Enter student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Student Marks: ");
       int marks = int.Parse(Console.ReadLine());
        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid Marks");
        }
        else if (marks >= 90)
        {
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Grade: C");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Grade: Fail");
        }
    }
}
