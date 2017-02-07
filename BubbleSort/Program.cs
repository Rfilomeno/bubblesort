using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /*class Program
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
                           // y = true;
                            i = 0;
                            /*if (x[0] > x[1])
                            {
                                troca = x[1];
                                x[1] = x[0];
                                x[0] = troca;
                            }*/
    /* }
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
}*/



    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 14, 5, 17, 9, 0, 11, 10, 15, 2, 1, 7 };
            int aux;

            for (int i = 0; i < x.Length; i++)
            {
                for (int o = 0; o < x.Length-1; o++)
                {
                    if (x[o]>x[o+1])
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

            var y = 0;
            int ini = x[0];
            var f = x[x.Length - 1];
            var m = x[(int)Math.Round((double)(x.Length - 1)/2)];
            
                for (int i = 0; i < x.Length; i++)
                
                    {
                try
                {

                    if (ini + m > 8)
                    {
                        f = m;
                        m = x[(int)Math.Round((double)(f / 2))];

                    }
                    else if (ini + m < 8)
                    {
                        ini = m;
                        m = x[(int)Math.Round((double)(f / 2))];
                    }
                    else if (ini + m == 8)
                    {
                        y = ini + m;
                        Console.WriteLine(y);
                        Console.ReadKey();
                        break;
                    }
                    else if (ini + m != 8)
                    {
                        Console.WriteLine("diferente de 8");
                        Console.ReadKey();
                    }


                    } catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.ReadKey();
                }
           

            }


        }
    }
}
