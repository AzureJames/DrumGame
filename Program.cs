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
            string[] drum = { "--------#", "-------#-", "------#--", "-----#---", "----#----", "---#-----", "--#------", "-#-------", "#--------" };




            Console.WriteLine("WELCOME TO DRUM GAME 2000\n");
            Console.WriteLine("TYPE A LETTER THEN \"ENTER\" TO BEGIN. TYPE \"t\" THEN ENTER FOR INSTRUCTIONS.");
            userInput = Console.ReadLine();
            Console.WriteLine("PRESS B EVERY TIME THE # AT THE SCREEN BOTTOM IS TO THE LEFT\n LIKE: #--------");
            if (userInput == "t")
            {
                Thread.Sleep(3900);
            }
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
            Console.WriteLine("IT STARTS FAST!");
            Thread.Sleep(950);
            
            for (int arrayLoop = 0; arrayLoop < 20; arrayLoop++)
            {
                for (int i = 0; i < 90; i++) //i<90   if i<85 for hard version
                {
                    
                    Console.WriteLine(drum[i/10]);

                    
                    //Thread.Sleep(100);

                    new Thread(() =>
                    {
                        while (true)
                        {
                            if (Console.KeyAvailable)
                            {
                                ConsoleKeyInfo keyInfo = Console.ReadKey();
                                //if (i < 8)
                                {
                                    //score -= 1;
                                }
                                if (i > 85)
                                {
                                    score += 1;
                                }
                            }

                        }
                    }).Start();
                    i++;
                }
            }
            
           

            Console.WriteLine($"GAME OVER. YOUR SCORE IS {score}/20.\n0-5 = poor \n6-12 = good\n13-17 = great\n18-20 = perfect");
            Thread.Sleep(1900);
            //public static System.Windows.Input.KeyStates GetKeyStates (System.Windows.Input.Key key);
        }
    }
}
