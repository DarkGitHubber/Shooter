namespace Shooter.Core
{
    public class M4 : Weapon
    {
        public override ushort MaxBullets => 30;
        public override decimal Price => 3200.00m;
        public override int Accuaracy => 50;
        public override double Damage => 200;

        public M4() : base(30)
        {

        }
    }



}
