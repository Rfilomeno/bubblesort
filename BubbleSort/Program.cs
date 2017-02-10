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
            int[] x = { 14, 5, 17, 9, 11, 10, 15, 2, 1, 8 };
            int aux;

            for (int i = 0; i < x.Length; i++)
            {
                for (int o = 0; o < x.Length - 1; o++)
                {
                    if (x[o] > x[o + 1])
                    {
                        aux = x[o];
                        x[o] = x[o + 1];
                        x[o + 1] = aux;
                    }
                }
            }
            foreach (var item in x)
            {
                Console.Write(item + " ");

            }
            Console.ReadKey();
            Console.WriteLine();
            Console.Write( "digite o numero que deseja achar no array:");
            
                int achar = Convert.ToInt32(Console.ReadLine());
            
            int inicio = 0;
            var fim = x.Length - 1;
            var meio = (inicio + fim) / 2;
            bool achei = false;

            for (int i = 0; i < x.Length; i++)

            {
                try { 
                if (x[meio]== achar || x[inicio] == achar || x[fim] == achar){
                Console.WriteLine("Encontrei o numero: " + achar);
                        achei = true;
                Console.ReadKey();
                break;
            }else if ((x[meio]) > achar)
            {
                fim = meio;
                meio = (inicio + fim) / 2;
            }
            else if ((x[meio]) < achar)
            {
                inicio = meio;
                meio = (inicio + fim) / 2;
            }

        }catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadKey();
                }
           

            }

            if (achei == false)
            {
                Console.WriteLine("não encontrei o numero: "+achar);
                Console.ReadKey();
            }
        }
    }
}
