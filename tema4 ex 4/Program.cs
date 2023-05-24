using System;

namespace test_infinit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea: ");
            int n = int.Parse(Console.ReadLine());

            int[] vect = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i + 1}: ");
                vect[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vectorul introdus este:");
            BubbleSort(vect);
            foreach (int num in vect)
            {
                Console.Write(num + " ");
            }
        }

        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
//Scrieti o functie recursiva care va afisa in ordine elementele unui vector de intregi


