using ArithmaticFunctions;

Operation operation = new Operation();

string choice;

Console.WriteLine("What arithmatic operation you want to perform");
Console.WriteLine("Addition/Subtraction/Multiplication/Division");

choice = Console.ReadLine();

Console.WriteLine("Enter the numbers respectively..");
operation.Number1 = Convert.ToInt32(Console.ReadLine());
operation.Number2 = Convert.ToInt32(Console.ReadLine());

switch (choice.ToLower())
{
    case "addition": operation.Add(); break;
    case "subtraction": operation.Subtract(); break;
    case "multiplication": operation.Multiply(); break;
    case "division": operation.Divide(); break;
    default: Console.WriteLine("Invalid inputs.."); break;
}