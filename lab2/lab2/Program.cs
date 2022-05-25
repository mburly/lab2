namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("Welcome to the Lab 2 Program!");
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("Please enter a number to multiply: ");
            var num1 = Console.ReadLine();
            Console.WriteLine("Please enter how high to multiply that number: ");
            var num2 = Console.ReadLine();
            int number = Int32.Parse(num1);
            int multiply = Int32.Parse(num2);
            for (int i = 0; i <= multiply; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{number} * 0 = 0, ");
                }
                else if (i == multiply)
                {
                    Console.Write($"{number} * {i} = {number * i}");
                }
                else
                {
                    Console.Write($"{number} * {i} = {number * i}, ");
                }
            }
        }
    }
}