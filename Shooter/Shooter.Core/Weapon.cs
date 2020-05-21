using System;

namespace Shooter.Core
{
    public abstract class Weapon
    {
        protected static readonly Random random = new Random();

        public abstract decimal Price { get;}
        public abstract ushort MaxBullets { get;}
        public abstract int Accuaracy { get;}
        public abstract double Damage { get;}
        public ushort BulletsLeft { get; set; }
        public bool IsEmpty => BulletsLeft==0;


        protected Weapon(ushort bulletsLeft)
        {
            BulletsLeft = bulletsLeft;
        }

        public virtual double Shoot()
        {
            if (BulletsLeft == 0)
                return 0;
            BulletsLeft--;
            return Damage / (100-random.Next(Accuaracy));
        }
        public void Reload()
        {
            BulletsLeft = MaxBullets;
        }


    }



}
