namespace Shooter.Core
{
    public class ShotGun : Weapon
    {
        public override ushort MaxBullets => 7;
        public override decimal Price => 1200;
        public override int Accuaracy => 20;
        public override double Damage => 200;

        public ShotGun() : base(7)
        {

        }
    }



}
