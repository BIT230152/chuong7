using System;
using System.Text;

public class FloatAndSingleExample
{
    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("2 cách khai báo 1 biến số thực 4 byte và gán giá trị khởi đầu là 3.0\r\n");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Float Example");
            Console.WriteLine("2. System.Single Example");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FloatExampleMenu();
                    break;
                case 2:
                    SingleExampleMenu();
                    break;
                case 3:
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void FloatExampleMenu()
    {
        float num1 = 3.14f;
        float num2 = 2.718f;
        float sum = num1 + num2;

        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        Console.WriteLine("Press Enter to return to the main menu...");
        Console.ReadLine();
    }

    static void SingleExampleMenu()
    {
        System.Single num1 = 3.14f;
        System.Single num2 = 2.718f;
        System.Single sum = num1 + num2;

        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        Console.WriteLine("Press Enter to return to the main menu...");
        Console.ReadLine();
    }
}