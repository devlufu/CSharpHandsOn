namespace ArithmaticFunctions
{
    public class Operation
    {
        public int Number1;
        public int Number2;

        public void Add()
        {
            Console.WriteLine($"Sum : {Number1 + Number2}");
        }

        public void Subtract()
        {
            Console.WriteLine($"Result : {Number1 - Number2}");
        }

        public void Multiply()
        {
            Console.WriteLine($"Product : {Number1 * Number2}");
        }

        public void Divide()
        {
            if (Number2 == 0)
            {
                Console.WriteLine("Invalid Input : Divide by 0 Error");
            }
            else
            {
                Console.WriteLine($"Result : {Number1 / Number2}");
            }
        }
    }
}