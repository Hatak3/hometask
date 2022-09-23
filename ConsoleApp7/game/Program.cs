using System;
using System.Collections.Generic;
using System.Text;
namespace Homework.Game
{
    public class Class1
    {
        static void Main(string[] args)
        {
            int BotWin= 0;
            int Humanwin = 0;
        
          
            bool IsGameContinum = true;
            while(IsGameContinum)
            {
                Console.WriteLine("rock,paper,scissors, choose one:");
                string choice = Console.ReadLine();
                Random random = new Random();
                int botChoice = random.Next(1, 4);
                switch (botChoice)
            {
                case 1:
                    if (choice.ToLower()=="rock")
                    {
                        Console.WriteLine("It's a Tie");
                    }
                    else if (choice.ToLower()=="paper")
                    {
                        Console.WriteLine("You won");
                        Humanwin++;
                        if (Humanwin==3)
                        {
                            Console.WriteLine($"You won with a score od {Humanwin}. game ended, bot {BotWin}");
                                IsGameContinum = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("bot won");
                            BotWin++;
                            if (BotWin==3)
                            {
                                Console.WriteLine($"Bot won with a score od {BotWin} . game ended, you {Humanwin}");
                                IsGameContinum = false;
                                break;
                            }
                        }
                    break;
                case 2:
                    if (choice.ToLower() == "paper")
                    {
                        Console.WriteLine("It's a Tie");
                    }
                    else if (choice.ToLower() == "rock")
                    {
                        Console.WriteLine("bot won");
                        BotWin++;
                        if (BotWin == 3)
                        {
                         Console.WriteLine($"Bot won with a score od {BotWin} . game ended, you {Humanwin}");
                         IsGameContinum = false;
                         break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you won");
                        Humanwin++;
                        if (Humanwin == 3)
                        {
                           
                            Console.WriteLine($"You won with a score od {Humanwin}. game ended, bot {BotWin}");
                            IsGameContinum = false;
                            break;
                        }
                    }
                    break;
                    case 3:
                        if (choice.ToLower() == "Scissors")
                        {
                            Console.WriteLine("It's a Tie");
                        }
                        else if (choice.ToLower() == "paper")
                        {
                            Console.WriteLine("bot won");
                            BotWin++;
                            if (BotWin == 3)
                            {
                                Console.WriteLine($"Bot won with a score od {BotWin} . game ended, you {Humanwin}");
                                IsGameContinum = false;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("you won");
                            Humanwin++;
                            if (Humanwin == 3)
                            {
                                Console.WriteLine($"You won with a score od {Humanwin}. game ended, bot {BotWin}");
                                IsGameContinum = false;
                                break;
                            }
                        }
                        break;
                    default:
                    break;
            }
            }
        }
    }
}
