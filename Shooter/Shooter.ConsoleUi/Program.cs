using System;
using Shooter.Core;

namespace Shooter.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FistShotLogic
            int firstShotLogic = new Random().Next(1,7);
            #endregion


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
                    player2.Money += 1600;
                    player1.Money += 800;
                    break;
                }

                if (!player2.IsAlive)
                {
                    Console.WriteLine($"...................{player1.Name} WINS................");
                    player1.Money += 1600;
                    player2.Money += 800;
                    break;
                }

            }
            Console.WriteLine($"Money of {player1.Name} " + player1.Money);
            Console.WriteLine($"Money of {player2.Name} " + player2.Money);



            Console.ReadLine();

        }
    }
}
