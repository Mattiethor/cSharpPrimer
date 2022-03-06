namespace CsharpPrimer
{
    class Program
    {

        // 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            Console.WriteLine("Press Enter to quit");

            string input = "x";
            int counter = 0;
            List<int> numberList = new List<int>();
            while (input != "")
            {
                counter++;

                Console.Write($"Number {counter}: ");
                input = Console.ReadLine();



                if (input == "")
                {
                    continue;
                }

                int userNumber = int.Parse(input);
                numberList.Add(userNumber);

            }

            int max = numberList.Max();
            int min = numberList.Min();

            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i]);

            }
            Console.WriteLine($"Biggest number: {max}");
            Console.WriteLine($"Smallest number: {min}");
        }

    }
}