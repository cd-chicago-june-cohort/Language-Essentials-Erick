using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai{
    public class Ninja : Human{
        public Ninja(string name) : base(name, 3, 3, 175, 100) { }

        public void steal(Human suckerGettingRobbed){
            health += 10;
            attack(suckerGettingRobbed);
        }
        public void get_away(){
            health -= 15;
        }
    }
}