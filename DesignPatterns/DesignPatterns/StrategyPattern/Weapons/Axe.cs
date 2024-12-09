using DesignPatterns.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.Weapons
{
    public class Axe : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Using the Axe.");
        }
    }
}
