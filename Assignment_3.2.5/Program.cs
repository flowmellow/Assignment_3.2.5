/*
Create a function that finds the index of a given item in the array
Examples
Search([1, 5, 3], 5) ➞ 1
Search([9, 8, 3], 3) ➞ 2
Search([1, 2, 3], 4) ➞ -1

Notes
If the item is not present, return -1.
*/

namespace Assignment_3._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dataSet1 = { 1, 5, 3 };
            int[] dataSet2 = { 9, 8, 3 };
            int[] dataSet3 = { 1, 2, 3 };
            int targetNum = 8;

            ValueSearchIndex(dataSet2, targetNum);
        }      
        static void ValueSearchIndex(int[] data, int select)
        {
            //optimized from original 
            bool valueFound = false;

            for (int i = 0; i < data.Length; i++)
            {               
                if (data[i] == select)
                {
                    Console.WriteLine($"The index of the selected value: {select} is {i} in the array.");
                    valueFound = true;
                    break;
                }             
            }
            if (valueFound == false)
            {
                Console.WriteLine("Item is not present return value -1");
            }

            // original
            //if (select == data[0])
            //{
            //    Console.WriteLine(0);

            //}
            //if (select == data[1])
            //{
            //    Console.WriteLine(1);

            //}
            //if (select == data[2])
            //{
            //    Console.WriteLine(2);

            //}
            //else if (select != data[0] && select != data[1] && select != data[2])
            //{

            //    Console.WriteLine("Item is not present return value -1");

            //}


        }
    }


}

