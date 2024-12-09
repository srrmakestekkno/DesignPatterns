using DesignPatterns.StrategyPattern.Weapons;

namespace DesignPatterns.StrategyPattern.Characters
{
    public class King : Character
    {
        public King()
        {
            SetWeapon(new Knife());
        }
        public override void Fight()
        {
            UseWeapon();
        }
    }
}
