namespace DeveloperTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("========= Task 1 =========");
            string name = "John Doe";
            int age = 25;
            bool isAdmin = true;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(isAdmin);
            Console.WriteLine("Press Enter to proceed to Task 2");
            Console.ReadLine();

            /* Task 2
             * Take an integer input from the user and prints out whether the number is even or odd
             */
            Console.WriteLine("========= Task 2 =========");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }

            else
            {
                Console.WriteLine("Odd");
            }
            Console.WriteLine("Press Enter to proceed to Task 3");
            Console.ReadLine();

            /* Task 3
             * Print out the numbers 1 to 10 using a for loop
             */
            Console.WriteLine("========= Task 3 =========");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press Enter to proceed to Task 4");
            Console.ReadLine();

            /* Task 4
             * Declare and initialize an integer array with the values 2, 4, 6, 8, 10
             * Print the sum of all elements in the array to the console
             * Use a foreach loop to iterate over the array and print each element to the console
             */
            Console.WriteLine("========= Task 4 =========");
            int[] numbers = {2, 4, 6, 8, 10};
            Console.WriteLine($"The sum of all the elements in number is {numbers.Sum()}");

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press Enter to proceed to Task 5");
            Console.ReadLine();

            /* Task 5
             * Write a method named Greet that takes a string parameter name and prints out a personalized greeting message
             */
            Greet("Alice");
            Console.WriteLine("Press Enter quit");
            Console.ReadLine();

        }

        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
