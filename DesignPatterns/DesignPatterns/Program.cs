
using DesignPatterns.StrategyPattern;
using DesignPatterns.StrategyPattern.Characters;
using DesignPatterns.StrategyPattern.Weapons;

Character king = new King();
king.Fight();
Console.WriteLine("Changing weapon to Axe...");
king.SetWeapon(new Axe());
king.Fight();


Console.ReadKey();