using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFindMax
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10000];

            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(0, 100000);
            }
            int indexfull = 0;
            int maxElement = array[0];
            int maxfull = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxfull)
                {
                    maxfull = array[i];
                    indexfull = i;
                }
            }
            for (int i = 1; i < array.Length; i++) {
                if (array[i] > maxElement && Math.Abs(indexfull - i) >= 2 && maxElement != maxfull)
                    maxElement = array[i];
            }
            Console.WriteLine("Second max element = " + maxElement);
            Console.ReadLine();

        }
    }
}
