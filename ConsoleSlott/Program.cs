using System;
using System.Timers;

namespace ConsoleSlott
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars for basic slot machine



            string wheel1 = " ";
            string wheel2 = " ";
            string wheel3 = " ";

            string slotBet;

            int SlotCoin;
            Console.Clear();
            Console.WriteLine("Welcome to the Casino");
            Console.WriteLine("Do you want to Bet");
            slotBet = Console.ReadLine();
           



            SlotCoin = 1000;
            do
            {
                
                wheel1 = WheelValue();
                wheel2 = WheelValue();
                wheel3 = WheelValue();

                Console.Write("|" + wheel1 + "|");
                System.Threading.Thread.Sleep(500);
                Console.Write("|" + wheel2 + "|");
                System.Threading.Thread.Sleep(500);
                Console.Write("|" + wheel3 + "|");
                Console.WriteLine(" ");
                if ((string.Equals(wheel1, wheel2)) && string.Equals(wheel2, wheel3))
                {
                    System.Threading.Thread.Sleep(500);
                    SlotCoin = SlotCoin + 100;
                    Console.WriteLine("You win");
                    Console.WriteLine("Coins: " + SlotCoin.ToString());
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    SlotCoin = SlotCoin - 50;
                    Console.WriteLine("You lose");
                    Console.WriteLine("Coins: " + SlotCoin.ToString());
                }
                Console.WriteLine("Bet again?");
                slotBet = Console.ReadLine();
            } while ((string.Equals(slotBet.ToUpper(), "YES")));
            
                Console.WriteLine("GoodBye");
                System.Threading.Thread.Sleep(500);
                System.Environment.Exit(0);
            
        }
        public static string WheelValue()
        {
            Random random = new Random();
            string WAns;
            int WSuit = random.Next(0,5);
           
            if (WSuit == 1)
            {
                WAns = "J";
            }
            else if (WSuit == 2)
            {
                WAns = "Q";
            }
            else if (WSuit == 3)
            {
                WAns = "K";
            }
            else
            {
                WAns = "Bar";
            }

            return WAns;
        }
    }
}
