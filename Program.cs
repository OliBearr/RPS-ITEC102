/*This code is created by Valenzuela, John Oliver Valenzueal for a semestral final group project
together with Briones, Brenn and Escamillas, Gerrylorence
To be submitted to Mr. Al John Villareal, Instructor |||

STARTED on December 3, 2023
FINISHED on December 16, 2023
*/

using System;
using System.Media;

namespace Rock_Paper_Scissors__Select_Number_
{
    internal class Program
    {
        static int playerOption = 0;
        static int computerOption = 0;
        static double playerScore = 0;
        static double computerScore = 0;
        static string[] options = { "ROCK", "PAPER", "SCISSORS" };
        static void Main(string[] args)
        {
        Start:
            /*
            string soundFilePath = "C:/Users/unigadget/Documents/Programming/C#/Rock-Paper-Scissors (Console App)/Mp3Juice-dot-Pet-Egzod-ft-evOke-Departure-lyrics-.mp3";
            SoundPlayer player = new SoundPlayer(soundFilePath);
            */
            Menu();
            Play();
            int computerChoice = new Random().Next(1, 4);
            computerOption = computerChoice - 1;
            //play computer pick animation
            if (computerOption == 0)
            {
                RockAnimationComputer();
            }
            if (computerOption == 1)
            {
                PaperAnimationComputer();
            }
            if (computerOption == 2)
            {
                ScissorAnimationComputer();
            }
            DetermineWinner();
            Console.Clear();
            goto Start;

        }
        public static void ModsConsole()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.Title = "ROCK PAPER SCISSORS";

        }
        public static void Menu()
        {
            ModsConsole();
            string startingBanner = @"
                                                                           /$$         /$$$$$$   /$$$$$$   /$$$$$$   /$$$$$$   /$$$$$$ 
                                                                          | $$        /$$__  $$ |____  $$ /$$__  $$ /$$__  $$ /$$__  $$
                                              /$$$$$$   /$$$$$$   /$$$$$$$| $$   /$$ | $$  \ $$  /$$$$$$$| $$  \ $$| $$$$$$$$| $$  \__/
                                             /$$__  $$ /$$__  $$ /$$_____/| $$  /$$/ | $$  | $$ /$$__  $$| $$  | $$| $$_____/| $$  
                                            | $$  \__/| $$  \ $$| $$      | $$$$$$/  | $$$$$$$/|  $$$$$$$| $$$$$$$/|  $$$$$$$| $$  
                                            | $$      | $$  | $$| $$      | $$_  $$  | $$____/  \_______/| $$____/  \_______/|__/  
                                            | $$      |  $$$$$$/|  $$$$$$$| $$ \  $$ | $$                | $$                      
                                            |__/       \______/  \_______/|__/  \__/ | $$                | $$                          
                                                                                     |__/                |__/                             
                                                                         /$$                                       
                                                                        |__/                                       
                                                      /$$$$$$$  /$$$$$$$ /$$  /$$$$$$$ /$$$$$$$  /$$$$$$   /$$$$$$  /$$$$$$$
                                                     /$$_____/ /$$_____/| $$ /$$_____//$$_____/ /$$__  $$ /$$__  $$/$$_____/
                                                    |  $$$$$$ | $$      | $$|  $$$$$$|  $$$$$$ | $$  \ $$| $$  \__/|  $$$$$$ 
                                                     \____  $$| $$      | $$ \____  $$\____  $$| $$  | $$| $$       \____  $$
                                                     /$$$$$$$/|  $$$$$$$| $$ /$$$$$$$//$$$$$$$/|  $$$$$$/| $$       /$$$$$$$/
                                                    |_______/  \_______/|__/|_______/|_______/  \______/ |__/      |_______/ 

";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (startingBanner.Length / 2)) + "}", startingBanner));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Player Score: " + playerScore);
            Console.WriteLine("Computer Score: " + computerScore);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            string introText = "Choose your pick";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (introText.Length / 2)) + "}", introText));
            Console.ResetColor();
            string choices = @"
            _   _   _    
   /|      |_) / \ /  |/ 
   _|_     | \ \_/ \_ |\  
";
            string choices2 = @"
    _        _       _   _  _  
     )      |_) /\  |_) |_ |_) 
    /_ _    |  /--\ |   |_ | \          
";
            string choices3 = @"
    _        __  _ ___  __  __  _   _  
    _)      (_  /   |  (_  (_  / \ |_) 
    _)      __) \_ _|_ __) __) \_/ | \                        
";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (choices.Length / 2)) + "}", choices));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (choices2.Length / 2)) + "}", choices2));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (choices3.Length / 2)) + "}", choices3));
            Console.ResetColor();
            Console.WriteLine();
        }
        public static void Play()
        {
            // 0 = ROCK, 1 = PAPER, 2 = SCISSOR
            Console.Write("Player (your) Pick: --> ");
            int playerPick = Convert.ToInt32(Console.ReadLine());
            playerOption = playerPick - 1;

            if (playerOption == 0)
            {
                Console.Clear();
                RockAnimationPlayer();
            }
            if (playerOption == 1)
            {
                Console.Clear();
                PaperAnimationPlayer();
            }
            if (playerOption == 2)
            {
                Console.Clear();
                ScissorAnimationPlayer();
            }


        }
        public static void DetermineWinner()
        {
            if (playerOption == computerOption)
            {
                Console.Clear();
                ItIsATie();

            }
            //Player Wins
            if (playerOption == 0 && computerOption == 2)
            {
                Console.Clear();
                PlayerWinBanner();
            }
            if (playerOption == 1 && computerOption == 0)
            {
                Console.Clear();
                PlayerWinBanner();
            }
            if (playerOption == 2 && computerOption == 1)
            {
                Console.Clear();
                PlayerWinBanner();
            }
            //Computer Wins
            if (playerOption == 0 && computerOption == 1)
            {
                Console.Clear();
                ComputerWinBanner();
            }
            if (playerOption == 1 && computerOption == 2)
            {
                Console.Clear();
                ComputerWinBanner();
            }
            if (playerOption == 2 && computerOption == 0)
            {
                Console.Clear();
                ComputerWinBanner();
            }
        }
        public static void ItIsATie()
        {
            Console.Clear();
            playerScore += 0.5;
            computerScore += 0.5;
            string itIsaTie = @"









                                           /$$$$$$ /$$           /$$                                 /$$$$$$$$ /$$$$$$ /$$$$$$$$ /$$
                                          |_  $$_/| $$          |__/                                |__  $$__/|_  $$_/| $$_____/| $$
                                            | $$ /$$$$$$         /$$  /$$$$$$$        /$$$$$$          | $$     | $$  | $$      | $$
                                            | $$|_  $$_/        | $$ /$$_____/       |____  $$         | $$     | $$  | $$$$$   | $$
                                            | $$  | $$          | $$|  $$$$$$         /$$$$$$$         | $$     | $$  | $$__/   |__/
                                            | $$  | $$ /$$      | $$ \____  $$       /$$__  $$         | $$     | $$  | $$          
                                           /$$$$$$|  $$$$/      | $$ /$$$$$$$/      |  $$$$$$$         | $$    /$$$$$$| $$$$$$$$ /$$
                                          |______/ \___/        |__/|_______/        \_______/         |__/   |______/|________/|__/
                                                                                          
                                                                                          
                                                                                OK FAIR ENOUGH
";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(itIsaTie);
            Console.ResetColor();
            System.Threading.Thread.Sleep(2000);
        }
        public static void ComputerWinBanner()
        {
            Console.Clear();
            computerScore += 1;
            string ComputerWin = @"









                          /$$$$$$                                                /$$                               /$$      /$$ /$$                           /$$
                         /$$__  $$                                              | $$                              | $$  /$ | $$|__/                          | $$
                        | $$  \__/  /$$$$$$  /$$$$$$/$$$$   /$$$$$$  /$$   /$$ /$$$$$$    /$$$$$$   /$$$$$$       | $$ /$$$| $$ /$$ /$$$$$$$   /$$$$$$$      | $$
                        | $$       /$$__  $$| $$_  $$_  $$ /$$__  $$| $$  | $$|_  $$_/   /$$__  $$ /$$__  $$      | $$/$$ $$ $$| $$| $$__  $$ /$$_____/      | $$
                        | $$      | $$  \ $$| $$ \ $$ \ $$| $$  \ $$| $$  | $$  | $$    | $$$$$$$$| $$  \__/      | $$$$_  $$$$| $$| $$  \ $$|  $$$$$$       |__/
                        | $$    $$| $$  | $$| $$ | $$ | $$| $$  | $$| $$  | $$  | $$ /$$| $$_____/| $$            | $$$/ \  $$$| $$| $$  | $$ \____  $$          
                        |  $$$$$$/|  $$$$$$/| $$ | $$ | $$| $$$$$$$/|  $$$$$$/  |  $$$$/|  $$$$$$$| $$            | $$/   \  $$| $$| $$  | $$ /$$$$$$$/       /$$
                         \______/  \______/ |__/ |__/ |__/| $$____/  \______/    \___/   \_______/|__/            |__/     \__/|__/|__/  |__/|_______/       |__/
                                                          | $$                                                                                                   
                                                          | $$                                                                                                   
                                                          |__/                                                                                                   
                                                                                    SORRY KIDDO :P";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ComputerWin);
            Console.ResetColor();
            System.Threading.Thread.Sleep(2000);
        }
        public static void PlayerWinBanner()
        {
            Console.Clear();
            Console.Beep();
            playerScore += 1;
            string PlayerWin = @"










                                     /$$$$$$$  /$$                                               /$$      /$$ /$$                           /$$
                                    | $$__  $$| $$                                              | $$  /$ | $$|__/                          | $$
                                    | $$  \ $$| $$  /$$$$$$  /$$   /$$  /$$$$$$   /$$$$$$       | $$ /$$$| $$ /$$ /$$$$$$$   /$$$$$$$      | $$
                                    | $$$$$$$/| $$ |____  $$| $$  | $$ /$$__  $$ /$$__  $$      | $$/$$ $$ $$| $$| $$__  $$ /$$_____/      | $$
                                    | $$____/ | $$  /$$$$$$$| $$  | $$| $$$$$$$$| $$  \__/      | $$$$_  $$$$| $$| $$  \ $$|  $$$$$$       |__/
                                    | $$      | $$ /$$__  $$| $$  | $$| $$_____/| $$            | $$$/ \  $$$| $$| $$  | $$ \____  $$          
                                    | $$      | $$|  $$$$$$$|  $$$$$$$|  $$$$$$$| $$            | $$/   \  $$| $$| $$  | $$ /$$$$$$$/       /$$
                                    |__/      |__/ \_______/ \____  $$ \_______/|__/            |__/     \__/|__/|__/  |__/|_______/       |__/
                                                             /$$  | $$                                                                         
                                                            |  $$$$$$/                                                                         
                                                            \______/                                                                          
                                                                               YOU GOT ME THERE";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(PlayerWin);
            Console.ResetColor();
            System.Threading.Thread.Sleep(2000);
        }
        public static void RockAnimationPlayer()
        {
            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking ROCK...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

        }

        public static void PaperAnimationPlayer()
        {
            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking PAPER...\n");

            Console.WriteLine(@"
    _______
---'   ____)______
          _________)
          _________)
         _________)
---.__________)
");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }

        public static void ScissorAnimationPlayer()
        {
            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("You are picking SCISSORS...\n");

            Console.WriteLine(@"
    _____
---'   __)_______
          _______)
       __________)
      (___)
---.__(___)
");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
        /*
         * 
         * 
         * 
         * 
         * 
         * 
        */
        public static void RockAnimationComputer()
        {
            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking ROCK...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

        }

        public static void PaperAnimationComputer()
        {
            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking PAPER...\n");

            Console.WriteLine(@"
    _______
---'   ____)______
          _________)
          _________)
         _________)
---.__________)
");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }

        public static void ScissorAnimationComputer()
        {
            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);

            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"


   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking...\n");

            Console.WriteLine(@"
   _______
--'   ____)_
         ____)
         ____)
        _____)
---._______)
");
            System.Threading.Thread.Sleep(100);
            Console.Clear();

            Console.WriteLine("Computer are picking SCISSORS...\n");

            Console.WriteLine(@"
    _____
---'   __)_______
          _______)
       __________)
      (___)
---.__(___)
");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
