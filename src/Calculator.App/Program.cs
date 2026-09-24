namespace Calculator.App
{
    class Program
    {
        static void Main(string[]args)
        {
            //main program here
            ShowMenu();


        }
        //methods written here
        static void ShowMenu()
        {
            Console.WriteLine("===Calculator===" +
            "\nChoose an option: " +
            "\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
        }
    }
}