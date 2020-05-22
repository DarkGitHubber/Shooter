using System;
using System.Collections.Generic;
using System.Text;

namespace Shooter.Core.Transport
{
    public interface ITankDriver
    {
        double Shoot();

        void Drive();

        double ShootMissile();
    }
}
