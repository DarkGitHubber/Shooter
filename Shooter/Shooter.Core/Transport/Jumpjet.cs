using System;
using System.Collections.Generic;
using System.Text;

namespace Shooter.Core.Transport
{
   
    public class Jumpjet
    {
        public IPilot Pilot { get; set; }

        public void Fly()
        {
            Pilot.Fly();
        }

        public void ThrowBombs()
        {
            Pilot.ThrowBombs();
        }
    }
}

