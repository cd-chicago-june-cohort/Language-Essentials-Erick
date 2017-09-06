using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai{
    public class Samurai : Human{
        public Samurai(string name) : base(name, 3, 3, 3, 200) { }

        public void death_blow(Human suckerGettingTheDeathBlow){
            if(suckerGettingTheDeathBlow.health < 50){
                suckerGettingTheDeathBlow.health = 0;
            }
            else{
                Console.WriteLine("Not a death blow");
            }
        }
        public void meditate(){
            health = 200;
        }
        
    }
}