using System;

namespace Starbucks
{
    public class UserInterface : IScreen
    {
        public void PrintMessage(string message)
        {
            Console.Write(message);
        }

        public void PrintMessageOnLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadChoice()
        {
            Console.Write("Your choice: ");
            String userInput;
            userInput = Console.ReadLine();
            return userInput;
        }

        public int ReadInputInteger()
        {
            int value = -1;
            if (int.TryParse(ReadChoice(), out value))
            {
                return value;
            }

            return 0;
        }

        public void ClearScreen()
        {
            Console.Clear();
        }
    }
}
