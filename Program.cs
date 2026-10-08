int Add(int a, int b)
{
    return a + b;
}
int Subtract(int a, int b)
{
    return a - b;
}
int Multiply(int a, int b)
{
    return a * b;
}
int Divide(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Cannot divide by zero.");
    }
    return a / b;
}

void Main(string[] args)
{
    while (true)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("1) Add");
        Console.WriteLine("2) Subtract");
        Console.WriteLine("3) Multiply");
        Console.WriteLine("4) Divide");
        Console.WriteLine("5) Exit");

        Console.WriteLine("Enter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 5)
        {
            break;
        }   

    Console.WriteLine("Enter first number:");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter second number:");
    int num2 = Convert.ToInt32(Console.ReadLine());

   
    int result = 0;

    switch (choice)
    {
        case 1:
            result = Add(num1, num2);
            break;
        case 2:
            result = Subtract(num1, num2);
            break;
        case 3:
            result = Multiply(num1, num2);
            break;
        case 4:
            try
            {
                result = Divide(num1, num2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            break;
        default:
            Console.WriteLine("Invalid choice.");
            return;
    }

    Console.WriteLine($"Result: {result}");
}
}
Main(args);
