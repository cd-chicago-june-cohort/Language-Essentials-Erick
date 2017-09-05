using System;

namespace ConsoleApplication {
    public class Human{
        public string name;
        public int strenght;
        public int intelligence;
        public int dexterity;
        public int health;
        public Human(string nameInput = "Gasper"){
            strenght = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
            name = nameInput;
        } 
        public Human(string nameInput, int strenghtInput, int intelligenceInput, int dexterityInput, int healthInput){
            name = nameInput;
            strenght = strenghtInput;
            intelligence = intelligenceInput;
            dexterity = dexterityInput;
            health = healthInput;
        } 
        public void attack(object humanInput){
            if(humanInput is Human){
                Human ExplicitHuman = humanInput as Human;
                ExplicitHuman.health -= strenght * 5;
            }
            else{
                Console.WriteLine("INPUT MUST BE OF TYPE HUMAN TO ATTACK!");
            }
        }     
    }   
}