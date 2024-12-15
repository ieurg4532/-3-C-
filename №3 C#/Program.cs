using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_C_
{
    internal class Program
    {
        void input(ref double[] array, ref string name)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0}[{1}] = ", name, i);
                array[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
        }

        void analysis(ref double[] array, ref double value, out double sum, out double average)
        {
            sum = average = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < value)
                {
                    sum += array[i];
                    k += 1;
                }
                if (k > 0) average = sum / k;
                else average = 0;
            }
        }

        static void Main(string[] args)
        {
            Program ob = new Program();

            string name1 = "alfa", name2 = "beta", name3 = "gamma";
            double sum1, sum2, sum3;
            double average1, average2, average3;

            Console.Write("Enter an amount of elements for alfa array n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] alfa = new double[n];

            Console.Write("Enter an amount of elements for beta array m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            double[] beta = new double[m];

            Console.Write("Enter an amount of elements for gamma array j = ");
            int j = Convert.ToInt32(Console.ReadLine());
            double[] gamma = new double[j];

            ob.input(ref alfa, ref name1);
            ob.input(ref beta, ref name2);
            ob.input(ref gamma, ref name3);

            Console.WriteLine("Enter a number to find the sum of array elements and their arithmetic mean that are less than the given number");
            Console.Write("Enter variant: ");

            double variant = Convert.ToDouble(Console.ReadLine());

            ob.analysis(ref alfa, ref variant, out sum1, out average1);
            ob.analysis(ref beta, ref variant, out sum2, out average2);
            ob.analysis(ref gamma, ref variant, out sum3, out average3);

            Console.WriteLine($"Arithmetic mean {name1}: {average1:F2};\tSum: {sum1:F2}");
            Console.WriteLine($"Arithmetic mean {name2}: {average2:F2};\tSum: {sum2:F2}");
            Console.WriteLine($"Arithmetic mean {name3}: {average3:F2};\tSum: {sum3:F2}");

        }
    }
}
