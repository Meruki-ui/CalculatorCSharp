namespace Calculator.App
{
    class Program
    {
        static void Main(string[]args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                //main program here
                ShowMenu();

                if (!TryReadNumber("Option: ", out double choice)) return;

                switch (choice)
                {
                   case 1: HandleAddit(); break;
                   case 2: HandleSubt(); break;
                   case 3: HandleMult(); break;
                   case 4: HandleDiv(); break;
                   case 0: keepGoing = false; break;  
                   default: Console.WriteLine("Invalid option, type a valid option."); break; 
                }
         
            }
  
        }
        //methods written here
        static void ShowMenu()
        {
            Console.WriteLine("===Calculator===" +
            "\nChoose an option: " +
            "\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n0. Quit");
        }
        static bool TryReadNumber(string prompt, out double result)
        {
            while (true)
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine() ?? "";

                    if (userInput == "q" || userInput == "Q"){
                        result = 0;
                        return false;
                    }
                    else if (double.TryParse(userInput, out result)){
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Type a number or 'q' to quit.");                    
                    }
            }
        }

        static void ShowResult(double result)
        {
            Console.WriteLine($"The result is: {result}");
        }

        static void HandleAddit()
        {
            if (!TryReadNumber("Type first number: ", out double a)) return;
            if (!TryReadNumber("Type second number: ", out double b)) return;

            double result = a + b;
            ShowResult(result);
        }

        static void HandleSubt()
        {
            if (!TryReadNumber("Type first number: ", out double a)) return;
            if (!TryReadNumber("Type second number: ", out double b)) return;

            double result = a - b;
            ShowResult(result);
        }

        static void HandleMult()
        {
            if (!TryReadNumber("Type first number: ", out double a)) return;
            if (!TryReadNumber("Type second number: ", out double b)) return;

            double result = a * b;
            ShowResult(result);
        }

        static void HandleDiv()
        {
            if (!TryReadNumber("Type first number: ", out double a)) return;
            if (!TryReadNumber("Type second number: ", out double b)) return;

            double result = a / b;
            ShowResult(result);
        }
    }
}