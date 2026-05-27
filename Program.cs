class Assignment7
{
    static double Add(double num1, double num2)
    {
        if (num1 == 0 && num2 == 0)
        {
            Console.WriteLine("Cannot add by zero!");
            return 0;
        }
        else if (num2 == 0)
        {
            Console.WriteLine("Cannot add by zero!");
            return 0;
        }
        else if (num1 == 0)
        {
            Console.WriteLine("Cannot add by zero!");
            return 0;
        }
        return num1 + num2;
    }

    static double Subtract(double num1, double num2)
    {
        if (num1 == 0 && num2 == 0)
        {
            Console.WriteLine("Cannot subtract by zero!");
            return 0;
        }
        else if (num2 == 0)
        {
            Console.WriteLine("Cannot subtract by zero!");
            return 0;
        }
        else if (num1 == 0)
        {
            Console.WriteLine("Cannot subtract by zero!");
            return 0;
        }
        return num1 - num2;
    }

    static double Multiply(double num1, double num2)
    {
        if (num1 == 0 && num2 == 0)
        {
            Console.WriteLine("Cannot multiply by zero!");
            return 0;
        }
        else if (num2 == 0)
        {
            Console.WriteLine("Cannot multiply by zero!");
            return 0;
        }
        else if (num1 == 0)
        {
            Console.WriteLine("Cannot multiply by zero!");
            return 0;
        }
        return num1 * num2;
    }

    static double Divide(double num1, double num2)
    {
        if (num1 == 0 && num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }
        else if (num2 == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }
        else if (num1 == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }
        return num1 / num2;
    }

    public static void Main(string[] args)
    {
        double num1, num2;

        Console.Write("Enter Your First Number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Your Second Number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Addition: {Add(num1, num2)}");
        Console.WriteLine($"Subtraction: {Subtract(num1, num2)}");
        Console.WriteLine($"Multiplication: {Multiply(num1, num2)}");
        Console.WriteLine($"Division: {Divide(num1, num2)}");
    }
}
