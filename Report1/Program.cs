using System;

namespace Hometask_1
{
    class NumbersInArray
    {
        static void Main(string[] args)
        {

            int[] numbersArray = new int[10];
            numbersArray[0] = 0;
            numbersArray[1] = 1;
            numbersArray[2] = 2;
            numbersArray[3] = 3;
            numbersArray[4] = 4;
            numbersArray[5] = 5;
            numbersArray[6] = 6;
            numbersArray[7] = 7;
            numbersArray[8] = 8;
            numbersArray[9] = 9;

            /*for (int i = 0; i < 10; i++)
            {
                numbersArray[i] = i;
                int w = i * 2;
                Console.WriteLine(w);
            }*/



            /*int a = 0;
            while (a < 10)
            {
                int b = a * 2;
                int i = numbersArray[a];
                Console.WriteLine(b);
                i=a++;

            }*/

            //comment//

            foreach (int z in numbersArray)
            {
                int f = z * 2;
                numbersArray[z] = z;
                Console.WriteLine(f);
            }



        }
    }
}
