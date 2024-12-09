using DesignPatterns.StrategyPattern.Interfaces;

namespace DesignPatterns.StrategyPattern.Weapons
{
    public class Knife : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using the Knife.");
        }
    }
}
