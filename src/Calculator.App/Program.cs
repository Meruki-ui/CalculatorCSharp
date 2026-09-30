namespace Calculator.App
{
    class Program
    {
        static void Main(string[]args)
        {
            List<string> history = new List<string>();
            bool keepGoing = true;
            while (keepGoing)
            {
                //main program here
                ShowMenu();

                if (!TryReadNumber("Option: ", out double choice)) return;

                switch (choice)
                {
                   case 1: HandleAddit(history); break;
                   case 2: HandleSubt(history); break;
                   case 3: HandleMult(history); break;
                   case 4: HandleDiv(history); break;
                   case 5: HandleSqrt(history); break;
                   case 6: HandleExpon(history); break;
                   case 7: ShowHistory(history); break;
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
            "\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Square Root\n6. Exponentiation\n7. History\n0. Quit");
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
        
        static void ShowHistory(List<string> history)
        {
            
            Console.WriteLine("These are your last 5 operations: \n");

            if (history.Count == 0)
            {
                Console.WriteLine("No operations yet.");
            }
            else
            {
                int start = Math.Max(0, history.Count-5);
                for (int i = start; i < history.Count; i++)
                {
                    Console.WriteLine($"{i - start + 1}- {history[i]}");
                }
            }

            Console.WriteLine("\nPress Enter to leave");
            Console.ReadLine();
            
        }

        static void AddToHistory(List<string> history, string entry)
        {
            history.Add(entry);
            if (history.Count > 5)
            {
                history.RemoveAt(0);
            }
        }

        static void HandleAddit(List<string> history)
        {
            if (!TryReadNumber("Type first number: ", out double a)) return;
            if (!TryReadNumber("Type second number: ", out double b)) return;

            double result = a + b;
            ShowResult(result);

            AddToHistory(history, $"{a} + {b} = {result}");
        }

        static void HandleSubt(List<string> history)
        {
            if (!TryReadNumber("Type first number: ", out double a)) return;
            if (!TryReadNumber("Type second number: ", out double b)) return;

            double result = a - b;
            ShowResult(result);

            AddToHistory(history, $"{a} - {b} = {result}");
        }

        static void HandleMult(List<string> history)
        {
            if (!TryReadNumber("Type first number: ", out double a)) return;
            if (!TryReadNumber("Type second number: ", out double b)) return;

            double result = a * b;
            ShowResult(result);

            AddToHistory(history, $"{a} * {b} = {result}");
        }

        static void HandleDiv(List<string> history)
        {
            if (!TryReadNumber("Type first number: ", out double a)) return;
            if (!TryReadNumber("Type second number: ", out double b)) return;

            double result = a / b;
            ShowResult(result);

            AddToHistory(history, $"{a} / {b} = {result}");
        }
        
        static void HandleSqrt(List<string> history)
        {
            if (!TryReadNumber("Type your number: ", out double a)) return;

            double result = Math.Sqrt(a);
            ShowResult(result);

            AddToHistory(history, $"√{a} = {result}");
        }

        static void HandleExpon(List<string> history)
        {
            if (!TryReadNumber("Type base number: ", out double a)) return;
            if (!TryReadNumber("Type exponent number: ", out double b)) return;

            double result = Math.Pow(a, b); 
            ShowResult(result);

            AddToHistory(history, $"{a}^{b} = {result}");
        }
    }
}