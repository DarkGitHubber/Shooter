using System;
using Shooter.Core;

namespace Shooter.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            //იმ შემთხვევაში თუ ეს დააბრუნებს კენტს მაშინ პირველი ისვრის  და შესაბამისად იგებს Player1, თუ ლუწს მაშინ PLayer2
            int firstShotLogic = new Random().Next(1,7); 

           var player1 = new Player();
           player1.Name = "Rambo";
           player1.BuyWeapon(new Glock47());

           var player2 = new Player();
           player2.Name = "Bond";
           player2.BuyWeapon(new Glock47());

            


            while (player1.IsAlive || player2.IsAlive )
            {
                if(firstShotLogic%2!=0)
                {
                    player1.TakeDamage(player2.Shoot());
                    Console.WriteLine($"{player2.Name} shoots {player1.Name}");
                    Console.WriteLine($"{player1.Name} Health is {player1.Health}");
                }
                else
                {
                    player2.TakeDamage(player1.Shoot());
                    Console.WriteLine($"{player1.Name} shoots {player2.Name}");
                    Console.WriteLine($"{player2.Name} Health is {player2.Health}");
                }

                if (!player1.IsAlive)
                {
                    Console.WriteLine($"...................{player2.Name} WINS................");
                    break;
                }

                if (!player2.IsAlive)
                {
                    Console.WriteLine($"...................{player1.Name} WINS................");
                    break;
                }






            }




            Console.ReadLine();

        }
    }
}
