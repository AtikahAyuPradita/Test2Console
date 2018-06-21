using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i;
            Console.Write("Input1 : ");
            N = int.Parse(Console.ReadLine());


            int[] A = new int[N];
            for (i = 0; i < N; i++)
            {
                Console.Write("Input2 : ");
                A[i] = int.Parse(System.Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Console.Write("0 ");
                }
                else
                {
                    if (A[i] > A[i - 1])
                    {
                        Console.Write("0 ");
                    }
                    else
                    {
                        int l = 0;
                        for (int k = i; k == 0; k--)
                        {
                            if (A[i] < A[k])
                            {
                                l++;
                            }
                        }
                        Console.WriteLine(l);
                    }
                }
            }
            Console.WriteLine("Press any key to continue . . . ");
            Console.ReadKey(true);
        } 
    }
}
                             