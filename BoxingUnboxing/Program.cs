using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object
            List<object> objList = new List<object>();

            // Add the following values to the list: 7, 28, -1, true, "chair"
            objList.Add(7);
            objList.Add(28);
            objList.Add(-1);
            objList.Add(true);
            objList.Add("chair");

            // Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach(var item in objList){
                Console.WriteLine(item);
            }

            // Add all values that are Int type together and output the sum
            int sum = 0;
            foreach(var item in objList){
                if(item is int){
                    sum += Convert.ToInt32(item);
                }
            }
            Console.WriteLine("This is the sum of all the ints in list: " + sum.ToString());
        }
    }
}
