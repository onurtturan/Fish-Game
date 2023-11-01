using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class SixNumber
{
    /*static void Main()
    {
        List<int> list = numberGive();

        int k = 0;
        while (k != 6)
        {
            Console.WriteLine(list[k]);
            k++;
        }
    }*/


    public static List<int> numberGive()
    {
        
        Random random = new Random();


        List<int> oddNumbers = new List<int> { 1, 3, 5, 7, 9 };


        List<int> numbers = new List<int>();

        List<int> finalNumbers = new List<int>();



        while (numbers.Count < 5)
        {
            int randomIndex = random.Next(oddNumbers.Count);
            int selectedNumber = oddNumbers[randomIndex];

            
            if (!numbers.Contains(selectedNumber))
            {
                numbers.Add(selectedNumber);
                numbers.Add(selectedNumber + 1);
            }
        }

        
        for (int i = 0; i < numbers.Count; i++)
        {
            int index = random.Next(i, numbers.Count);
            int temp = numbers[i];
            numbers[i] = numbers[index];
            numbers[index] = temp;
        }

        /*int k = 0;
        while (k != 6)
        {
            Console.WriteLine(numbers[k]);
            k++;
        }

        Console.WriteLine("------------");*/







        int j = 0;
        for (int h = 0; h < numbers.Count; h++)
        {
            if (numbers[h] % 2 == 1)
            {
                finalNumbers.Add(numbers[h]);
                numbers.Remove(numbers[h]);

            }
            else
            {
                if (!numbers.Contains(numbers[h] - 1))
                {
                    finalNumbers.Add(numbers[h]);
                    numbers.Remove(numbers[h]);
                }


            }

        }

        for (int h = 0; h < numbers.Count; h++)
        {
            if (numbers[h] % 2 == 1)
            {
                finalNumbers.Add(numbers[h]);
                numbers.Remove(numbers[h]);

            }
            else
            {
                if (!numbers.Contains(numbers[h] - 1))
                {
                    finalNumbers.Add(numbers[h]);
                    numbers.Remove(numbers[h]);
                }


            }

        }

        
        while (numbers.Count > 0)
        {
            int temp;
            int z = 0;


            if (numbers[j] % 2 == 1)
            {
                finalNumbers.Add(numbers[j]);
                numbers.Remove(numbers[j]);

            }
            else
            {
                if (!numbers.Contains(numbers[j] - 1))
                {
                    finalNumbers.Add(numbers[j]);
                    numbers.Remove(numbers[j]);
                }
                else
                {
                    if (z == 0) { temp = numbers[j]; numbers.Remove(numbers[j]); numbers.Insert(1, temp); z++; }
                    else { temp = numbers[j]; numbers.Remove(numbers[j]); numbers.Add(temp); }
                }

            }


        }

        return finalNumbers;






    }
}
