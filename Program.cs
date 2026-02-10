using System;

class Program
{
    static void Main()
    {
        // 1. Variables
        string name;
        int age;
        double height;
        bool isStudent;

        // 2. Input from user
        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.Write("Enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your height in meters: ");
        height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Are you a student (true/false)? ");
        isStudent = Convert.ToBoolean(Console.ReadLine());

        // 3. Output
        Console.WriteLine("\n--- User Information ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height + " m");
        Console.WriteLine("Student: " + isStudent);

        // 4. Simple calculation
        int nextYearAge = age + 1;
        Console.WriteLine("\nNext year, you will be " + nextYearAge + " years old.");

        // Keep console open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
