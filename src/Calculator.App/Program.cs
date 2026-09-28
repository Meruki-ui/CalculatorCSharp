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
                keepGoing = false;         
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
    }
}