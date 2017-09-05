using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        // Print 1-255
        public static void oneTo255(){
            for(var k=1;k<=255;k++){
                Console.WriteLine(k);
            }
        }
        // Print odd numbers between 1-255
        public static void oddOneTo255(){
            for(var k=1;k<=255;k+=2){
                Console.WriteLine(k);
            }
        }
        // Print Sum
        public static void printSum(){
            int sum = 0;
            for(var k=0;k<=255;k++){
                sum += k;
                Console.WriteLine("New number: " + k.ToString() + " Sum: " + sum.ToString());
            }
        }
        // Iterating through an Array
        public static void IteratingThroughArray(int[] arr){
            foreach(int val in arr){
                Console.WriteLine(val);
            }
        }
        // Find Max
        public static int findMax(int[] arr){
            int max = arr[0];
            for(var k=1;k<arr.Length;k++){
                if(arr[k] > max){
                    max = arr[k];
                }
            }
            return max;
        }
        // Get Average
        public static double findAverage(int[] arr){
            int sum = arr[0];
            for(var k=1;k<arr.Length;k++){
                sum += arr[k];
            }
            double avg = sum / arr.Length;
            return avg;
        }
        // Array with Odd Numbers
        public static int[] arrayWithOdds(){
            List<int> oddArr = new List<int>();
            for(var k=1;k<=255;k+=2){
                oddArr.Add(k);
            }
            return oddArr.ToArray();
        }
        // Greater than Y
        public static int greaterThanY(int[] arr, int y){
            int counter = 0;
            for(var k=0;k<arr.Length;k++){
                if(arr[k] > y){
                    counter += 1;
                }
            }
            return counter;
        }
        // Square the Values
        public static int[] squareValuesInArray(int[] arr){
            for(var k=0;k<arr.Length;k++){
                arr[k] = arr[k] * arr[k];
            }
            return arr;
        }
        // Eliminate Negative Numbers
        public static int[] eliminateNegNums(int[] arr){
            for(var k=0;k<arr.Length;k++){
                if(arr[k] < 0){
                    arr[k] = 0;
                }
            }
            foreach(int val in arr){
                Console.WriteLine(val);
            }
            return arr;
        }
        // Min, Max, and Average
        public static void MinMaxAvg(int[] arr){
            int min = arr[0];
            int max = arr[0];
            int sum = arr[0];
            for(var k=0;k<arr.Length;k++){
                if(arr[k] < min){
                    min = arr[k];
                }
                if(arr[k] > max){
                    max = arr[k];
                }
                sum += arr[k];
            }
            float avg = sum / arr.Length;
            Console.WriteLine("The min is " + min.ToString());
            Console.WriteLine("The max is " + max.ToString());
            Console.WriteLine("The avg is " + avg.ToString());
        }
        // Shifting the values in an array
        public static void shiftArrayByOne(int[] arr){
            for(var k=0;k<arr.Length;k++){
                if(k == (arr.Length-1)){
                    arr[k] = 0;
                }
                else{
                    arr[k] = arr[k+1];
                }
            }
            foreach(int arrVal in arr){
                Console.WriteLine(arrVal);
            }
        }
        // Number to String
        public static object[] numToString(int[] arr){
            List<object> newArr = new List<object>();
            for(var k=0;k<arr.Length;k++){
                if(arr[k] < 0){
                    newArr.Add("Dojo");
                }
                else{
                    newArr.Add(arr[k]);
                }
            }
            return newArr.ToArray();
        }

        static void Main(string[] args)
        {
            // test cases
            int[] intArr = {1,3,5,7,9,13};
            int[] intArr2 = {2, 10, 3};
            int[] intArr3 = {1, 5, 10, -2};
    
            oneTo255();
            oddOneTo255();
            printSum();
            IteratingThroughArray(intArr);
            Console.WriteLine(findMax(intArr));
            Console.WriteLine(findAverage(intArr2));
            Console.WriteLine(arrayWithOdds());
            Console.WriteLine(greaterThanY(intArr, 8)); 
            Console.WriteLine(squareValuesInArray(intArr));
            Console.WriteLine(eliminateNegNums(intArr3));
            MinMaxAvg(intArr);
            shiftArrayByOne(intArr);
            numToString(intArr3);
        }
    }
}
