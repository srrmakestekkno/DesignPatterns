using DesignPatterns.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public abstract class Character
    {
        private IWeaponBehavior weaponBehavior;

        public void SetWeapon(IWeaponBehavior weapon)
        {
            weaponBehavior = weapon;
        }

        protected void UseWeapon()
        {
            weaponBehavior.UseWeapon();
        }

        public abstract void Fight();
    }
}
