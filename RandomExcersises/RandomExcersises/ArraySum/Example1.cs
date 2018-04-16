using System;
using System.Collections.Generic;
using System.Text;

namespace RandomExcersises.ArraySum
{
    class Example1
    {
        public void sumArray()
        {

            try
            {
                /*get the number of arrays that you are going to sum*/
                int arrayNumber = Int32.Parse(Console.ReadLine());

                String[] arraylist = null;

                /*get the length of the array in order to create a new array for adding the result*/

                arraylist = Console.ReadLine().Split(' ');

                /*get the digit size*/
                int digitsize = arraylist[0].ToCharArray().Length;

                /*Create the place to store the result*/
                int[] result = new int[digitsize];

                /*filling the array with zeros before the adding*/
                for (int i = 0; i < digitsize; i++)
                {
                    result[i] = 0;
                }

                /*sum all the vectors into 1 array*/
                for (int i = 0; i < arrayNumber; i++)
                {
                    /*transform the string into a char array*/
                    char[] preIntArray = arraylist[i].ToCharArray();

                    /*Create the array where you store inside of the int array*/
                    int[] temparray = new int[digitsize];

                    /*loop to parse thhe chars into ints*/
                    for (int n = 0; n < digitsize; n++)
                    {
                        temparray[n] = Int32.Parse(preIntArray[n].ToString());    
                    }
                    /*save the result in a variable and be usable for the next iteration*/
                    result = sumArrays(temparray, result, digitsize);


                }
                /*print the result*/
                foreach (int number in result)
                {
                    Console.Write(number);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        int[] sumArrays(int[] Array1, int [] Array2, int arraysize)
        {
            int[] result = new int[arraysize];
            int excess = 0;

            /*looping for adding the 2 arrays*/
            for (int i = (arraysize - 1); i > -1; i--)
            {
                int resultofSum = Array1[i] + Array2[i] + excess;

                if (resultofSum >= 10)
                {
                    excess = 1;
                    result[i] = resultofSum - 10;
                }
                else
                {
                    result[i] = resultofSum;
                    excess = 0;
                }

            }


            return result;
        }
    }
}

