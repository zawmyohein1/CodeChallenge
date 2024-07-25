using CodeChallenge.Core;
using System;

namespace CodeChallenge.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string for the OldPhonePad:");
            string input = Console.ReadLine();
            string output = OldPhonePad.ParseInput(input);
            Console.WriteLine($"Output: {output}");
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        #region Input Explaination

        //OldPhonePad("33#") => "E"
        //3 pressed twice results in E.

        //OldPhonePad("227#") => "B"*
        //2 pressed twice results in B, 7 results in * which is backspace, so B is returned.

        //OldPhonePad("4433555 555666#") => "HELLO"
        //44 -> H, 33 -> E, 555 -> L, 555 -> L, 666 -> O.

        //OldPhonePad("8 88777444666*664#") => "?"
        //Assuming the * would backspace and considering the sequence might be ambiguous, this would need clarification on the expected behavior for ?.

        #endregion
    }
}


