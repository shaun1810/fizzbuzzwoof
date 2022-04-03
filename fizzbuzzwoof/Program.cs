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
            }

        }
    }

    public static void StandardRules()
    {
        var numbers = ArrayCreator();
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
        else
        {
            Console.WriteLine("No numbers entered!");
        }
    }
    public static void Customrules()
    {
        var rules = RulesCreator();
       
        if (rules.Count != 0)
        {
            var array = ArrayCreator();
            for (int i = 0; i == array.Length; i++)
            {
                foreach (KeyValuePair<int, string> rule in rules)
                {
                    if (rule.Key == array[i])
                    {
                        Console.WriteLine(rule.Value);
                    }
                }
            }
        }
        else { Console.WriteLine("No rules entered!"); }
    }

    public static int[] ArrayCreator()
    {
        List<int> playingNumbers = new List<int>();
        bool userSelectingNumbers = true;
        Console.WriteLine("Please input numbers to check! input . when finished");
        while (userSelectingNumbers == true)
        {

            int result;
            var input = Console.ReadLine();
            if (int.TryParse(input, out result) == true)
            {
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
        return numbers;
    }

    public static List<KeyValuePair<int, string>> RulesCreator() 
    {
        Console.WriteLine("Please Follow instructions Input . at any time to stop creating rules!");
        var rules = new List<KeyValuePair<int, string>>();
        bool userCreatingRules = true;
        while (userCreatingRules == true)
        {
            int result;
            Console.WriteLine("Please enter a number to find multiples of!");
            var choice = Console.ReadLine();
            if ((int.TryParse(choice, out result) == true))
            {
                bool wordSelecting = true;
                while (wordSelecting == true)
                {
                    Console.WriteLine("Please input a buzz word!");
                    var word = Console.ReadLine();
                    if (!string.IsNullOrEmpty(word))
                    {
                        rules.Add(new KeyValuePair<int, string>(result, word));
                        wordSelecting = false;
                    }
                    else { Console.WriteLine("Word cannot be null!\n"); }
                }
            }
            else
            {
                if (choice == ".")
                {
                    userCreatingRules = false;
                }
                else
                {
                    Console.Write("Please input a number!\n");
                }
            }

        }
        return rules;
    }
}
