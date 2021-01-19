using System;
using System.Threading;


namespace DrumGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int score = 0;
            string[] drum = { "00000000#", "0000000#0", "000000#00", "00000#000", "0000#0000", "000#00000", "00#000000", "0#0000000", "#00000000" };




            Console.WriteLine("WELCOME TO DRUM GAME 2000\n");
            Console.WriteLine("PRESS ENTER TO BEGIN");
            userInput = Console.ReadLine();
            Console.WriteLine("STARTING");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Thread.Sleep(500);
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Console.WriteLine(".........");
            Thread.Sleep(500);

            for (int arrayLoop = 0; arrayLoop < 20; arrayLoop++)
            {
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine(drum[i]);

                    
                    Thread.Sleep(500);


                    //if ((Keyboard.GetKeyStates(Key.Return) & KeyStates.Down) > 0)
                    {
                        if (i < 8)
                        {
                            score -= 1;
                        }
                        else
                        {
                            score++;
                        }
                    }
                }
            }
            
           

            Console.WriteLine($"GAME OVER. YOUR SCORE IS {score}");
            Thread.Sleep(1900);
            //public static System.Windows.Input.KeyStates GetKeyStates (System.Windows.Input.Key key);
        }
    }
}
