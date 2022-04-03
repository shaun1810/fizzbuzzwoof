public class Program
{
    public static void Main()
    {
        bool userPlaying = true;
        while (userPlaying == true)
        {
            Console.WriteLine("Welcome to Fizz, Buzz, Woof!\n Options\n 1. Standard rules\n 2. Create your own rules!\n 3. Close Program");
            bool awaitingOption = true;
            while (awaitingOption == true)
            {
                var choice = Console.ReadLine();
                if (choice == "1")
                {
                    StandardRules();
                    awaitingOption = false;
                }
                if (choice == "2")
                {
                    Customrules();
                    awaitingOption = false;
                }
                if (choice == "3")
                {
                    Environment.Exit(0);
                }
                else {
                    Console.WriteLine("Please enter a valid option!");
                }

            }

        }
    }

    public static void StandardRules()
    {        
        List<int> playingNumbers = new List<int>();
        bool userSelectingNumbers = true;
        Console.WriteLine("Please input numbers to check! input . when finished");
        while (userSelectingNumbers == true)
        {
            
            int result;
            var input = Console.ReadLine();         
            if (int.TryParse(input, out result) == true) {
                playingNumbers.Add(result);
            }
            else
            {
                if (input == ".")
                {
                    userSelectingNumbers = false;
                }
                else
                {
                    Console.WriteLine("Please only input numbers or the stop command .!");
                }
            }
        }
        int[] numbers = playingNumbers.ToArray();
        if (numbers.Length != 0)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz!");
                }
                if (numbers[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz!");
                }
                if (numbers[i] % 7 == 0)
                {
                    Console.WriteLine("Woof!");
                }
            }
        }
        else {
            Console.WriteLine("No numbers entered!");
        }
    }
    public static void Customrules() { 
    
        Console.WriteLine("Please Create you own rules enter a number to divise by and a word to play to find the multiples!");
        bool userCreatingRules = true;
        while (userCreatingRules)
    
    }
}