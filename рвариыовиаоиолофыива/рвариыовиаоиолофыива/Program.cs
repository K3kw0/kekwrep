using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рвариыовиаоиолофыива
{
    class Program
    {
        static void q(out int[] a)
        {
            int n = (100 - 10) / 9;
            a = new int[n];
            int zxc = 0;
            for (int i = 18; i < 100; i += 9)
            {
                a[zxc] = i;
                if (i >= 10) zxc++;
            }
        }

        static void Main(string[] args)
        {
            q(out int[] a);
            Console.Write("Полученный массив --> ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
            Console.WriteLine();
        }

    }
}
