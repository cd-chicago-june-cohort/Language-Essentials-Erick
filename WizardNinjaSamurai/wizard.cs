using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai{
    public class Wizard : Human{
        public Wizard(string name) : base(name, 3, 25, 3, 50) { }

        public void heal(){
            health += 10 * intelligence;
        }
        public void fireball(Human suckerGettingFireballed){
            Random rnd = new Random();
            suckerGettingFireballed.health -= rnd.Next(20, 51);
        }
    }
}