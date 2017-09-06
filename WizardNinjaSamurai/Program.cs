using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard erick = new Wizard("Erick");
            Ninja gasper = new Ninja("Gasper");
            Samurai frida = new Samurai("Frida");
            erick.heal();
            Console.WriteLine("Name: " + gasper.name + " Strength: " + gasper.strength + " Intelligence: " + gasper.intelligence + " Dexterity: " + gasper.dexterity + " Health: " + gasper.health);
            erick.fireball(gasper);
            Console.WriteLine("Name: " + gasper.name + " Strength: " + gasper.strength + " Intelligence: " + gasper.intelligence + " Dexterity: " + gasper.dexterity + " Health: " + gasper.health);
        }
    }
}
