namespace HW3
{
    internal class Program
    {
        delegate void PrintString(string message);
        static void Main(string[] args)
        {
            PrintString printString;
            Print print = new Print();
            printString = print.PrintGreenMessage;
            printString += print.PrintOrangeMessage;

            printString("I have the different colors.");
            //set default text color
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}