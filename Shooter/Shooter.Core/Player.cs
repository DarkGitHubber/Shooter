using Shooter.Core.Transport;
using System.Collections.Generic;
using System.Text;

namespace Shooter.Core
{

    public class Player : IPlayer,IPilot,ITankDriver
    {
        public string Name { get; set; } = "player";
        public double Health { get; set; } = 100;
        public decimal Money { get; set; } = 800;
        public Weapon Weapon { get; set; }
        public bool IsAlive => Health > 0;


        public bool BuyWeapon(Weapon weapon)
        {
            if (Money < weapon.Price)
                return false;
            Money -= weapon.Price;
            Weapon = weapon;
            return true;
        }

        public void Reload()
        {
            Weapon.Reload();
        }

        public double Shoot()
        {
            if(Weapon.IsEmpty)
                Weapon.Reload();
            return Weapon.Shoot();
        }

        public void TakeDamage(double damage)
        {
            if (damage >= Health)
                Health = 0;
            else
                Health-=damage;
        }

        void ITankDriver.Drive()
        {
            throw new System.NotImplementedException();
        }

        void IPilot.Fly()
        {
            throw new System.NotImplementedException();
        }

        double ITankDriver.Shoot()
        {
            throw new System.NotImplementedException();
        }

        double ITankDriver.ShootMissile()
        {
            throw new System.NotImplementedException();
        }

        void IPilot.ThrowBombs()
        {
            throw new System.NotImplementedException();
        }
    }



}
