using System;
using System.Diagnostics;

namespace googleit
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
         * IL instructions
         * 
         * IL -> Intermediate Language
         * 
         * Processed by your CPU as "checkpoints"
         * Able to use statements like "goto"
         * Initialize a checkpoint by using either
         * 
         * IL_main:
         * 
         * OR
         * 
         * main:
         */


        main:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Google it: ");
        input:
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrEmpty(input)) goto input;
            OpenGoogle(input);
            goto main;
        }

        static void OpenGoogle(string input)
        {
            var uri = "http://www.google.com/search?q=" + input;
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            Process.Start(psi);
        }
    }
}
