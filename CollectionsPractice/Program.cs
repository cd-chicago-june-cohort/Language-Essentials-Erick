using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to hold integer values 0 through 9
            int[] intArr = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach(int num in intArr){
                Console.WriteLine(num);
            }

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] strArr = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            foreach(string str in strArr){
                Console.WriteLine(str);
            }

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArr = new bool[] {true, false, true, false, true, false, true, false, true, false};
            foreach(bool boolVal in boolArr){
                Console.WriteLine(boolVal);
            }

            // With the values 1-10, use code to generate a multiplication table like the one below.
            int[,,] multiArr = new int[10, 1, 10];
            
            // Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Blueberry Cobbler");
            flavors.Add("Cake Batter");
            flavors.Add("Caramel Swirl");
            flavors.Add("Pistachio");
            flavors.Add("Snickerdoodle");

            // Output the length of this list after building it
            Console.WriteLine(flavors.Count);

            // Output the third flavor in the list, then remove this value.
            Console.WriteLine(flavors[2]);
            flavors.Remove("Caramel Swirl");

            // Output the new length of the list (Note it should just be one less~)
            Console.WriteLine(flavors.Count);

            // Create a Dictionary that will store both string keys as well as string values
            Dictionary<string,string> user = new Dictionary<string,string>();

            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null
            user.Add(strArr[0],null);
            user.Add(strArr[1],null);
            user.Add(strArr[2],null);
            user.Add(strArr[3],null);

            // For each name key, select a random flavor from the flavor list above and store it as the value
            user[strArr[0]] = flavors[0];
            user[strArr[1]] = flavors[1];
            user[strArr[2]] = flavors[2];
            user[strArr[3]] = flavors[3];

            // Loop through the Dictionary and print out each user's name and their associated ice cream flavor.
            foreach(var userInfo in user){
                Console.WriteLine(userInfo);
            }
        }   
    }
}
