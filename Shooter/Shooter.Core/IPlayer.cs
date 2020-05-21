namespace Shooter.Core
{
    interface IPlayer
    {
        bool BuyWeapon(Weapon weapon);
        double Shoot();
        void Reload();
        void TakeDamage(double damage);
        public bool IsAlive { get; }
    }



}
