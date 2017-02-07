using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 14, 5, 17, 9, 0, 11, 10, 15 };
            bool y = false;
            int troca;
            do
            {                
                for (int i = 0; i < x.Length; i++)
                {
                    y = false;
                    try
                    {
                        if (x[i] > x[i + 1])
                        {
                            troca = x[i + 1];
                            x[i + 1] = x[i];
                            x[i] = troca;
                            y = true;
                            i = 0;
                            /*if (x[0] > x[1])
                            {
                                troca = x[1];
                                x[1] = x[0];
                                x[0] = troca;
                            }*/
                        }
                    }
                    catch (System.IndexOutOfRangeException) { }
                    
                }
            } while (y);

            foreach (var item in x)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
