using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        // Random Array
        public static int[] RandomArray(){
            Random randInt = new Random();
            int[] intArr = new int[10]; 
            for(var k=0;k<intArr.Length;k++){
                intArr[k] = randInt.Next(5, 26);
            }
            int max = intArr[0];
            int min = intArr[0];
            int sum = intArr[0];
            for(var i=1;i<intArr.Length;i++){
                if(intArr[i] < min){
                    min = intArr[i];
                }
                if(intArr[i] > max){
                    max = intArr[i];
                }
                sum += intArr[i];
            }
            Console.WriteLine("The max of the new array is " + max.ToString());
            Console.WriteLine("The min of the new array is " + min.ToString());
            Console.WriteLine("The sum of the new array is " + sum.ToString());
            return intArr;
        }

        // Coin Flip
        public static string TossCoin(){
            Random randInt = new Random();
            Console.WriteLine("Tossing a Coin!");
            int value = randInt.Next(0, 2);
            string result  = " ";
            if(value == 0){
                Console.WriteLine("Tails");
                result = "Tails";
            }
            else{
                Console.WriteLine("Heads");
                result = "Heads";
            }
            return result;
        }

        // Coin Flip V2
        public static string TossMultipleCoins(int num){
            int heads = 0;
            int tails = 0;
            string result;
            for(var k=0;k<num;k++){
                result = TossCoin();
                if(result == "Tails"){
                    tails += 1;
                }
                else{
                    heads += 1;
                }
            }
            string ratio = $"ratio between heads and tails is {heads}:{tails}";
            return ratio;
        }

        // Names
        public static string[] names(){
            Random randInt = new Random();
            List<string> newNames = new List<string>();
            string[] names = new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            
            for(var k=0;k<names.Length;k++){
                Console.WriteLine(names[randInt.Next(0,names.Length)]);
                if(names[k].Length > 5){
                    newNames.Add(names[k]);
                }
            }
            return newNames.ToArray();
        }

        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            Console.WriteLine(TossMultipleCoins(36));
            names();
        }
    }
}
