// See https://aka.ms/new-console-template for more information
//Read the options such as Add, Subtract, Multiply and Divide from the user Hint: Console.ReadLine
//Based on the operation selected ask for following input
//If Addition is selected, Enter the first and second number for addition
//If Subtraction is selected, Enter the number 1 and
bool running=true;
while (running)
{
    Console.WriteLine("Enter the two numbers:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your choice\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Sum="+(num1 + num2));
            break;
        case 2:
            Console.WriteLine("Difference="+ (num1 - num2));
            break;
        case 3:
            Console.WriteLine("Product="+ (num1 * num2));
            break;
        case 4:
            if (num2 == 0) Console.WriteLine($"denominator can't be zero");
            else Console.WriteLine("Quotient="+ (num1 / num2));
            break;
        case 5:
            running = false;
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;

    }
}