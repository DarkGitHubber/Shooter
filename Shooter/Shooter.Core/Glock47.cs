namespace Shooter.Core
{
    public class Glock47 : Weapon
    {
        public override ushort MaxBullets => 20;
        public override decimal Price => 800;
        public override int Accuaracy => 10;
        public override double Damage => 200;

        public Glock47() : base(20)
        {

        }
    }



}
