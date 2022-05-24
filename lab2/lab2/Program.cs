namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("Welcome to the Lab 2 Program!");
            Console.WriteLine("*=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("Please enter one number to add:");
            var num1 = Console.ReadLine();
            Console.WriteLine("Please enter the other number you wish to add:");
            var num2 = Console.ReadLine();
            int sum = Int32.Parse(num1) + Int32.Parse(num2);
            Console.WriteLine($"{num1} + {num2} = {sum}");
        }
    }
}