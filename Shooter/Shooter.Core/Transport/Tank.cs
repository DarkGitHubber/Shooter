using System;
using System.Collections.Generic;
using System.Text;

namespace Shooter.Core.Transport
{

   
    public class Tank
    {
        public ITankDriver TankDriver { get; set; }

        public double ShootMissile()
        {
            return TankDriver.ShootMissile();
        }

        public double Shoot()
        {
            return TankDriver.Shoot() + 5;
        }

        public void Drive()
        {
            TankDriver.Drive();
        }
    }
}
