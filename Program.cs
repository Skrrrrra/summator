using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int count = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            
            int[] summ = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                shop(n, summ, count);
                count++;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(summ[i]);
            }
        }
        public static int shop(int n, int[] summ,int count)
        {
            int CountOfBuyProducts = int.Parse(Console.ReadLine());
            List<int> buys = new List<int>();
            string line = Console.ReadLine();
            string[] lineToParse = new string[n];
            lineToParse = line.Split(' ');
            for (int i = 0; i < lineToParse.Length; i++)
            {
                buys.Add(int.Parse(lineToParse[i]));
            }

            List<int> distinct = buys.Distinct().ToList();
            int[] countOfProducts = new int[distinct.Count];

            for (int i = 0; i < distinct.Count; i++)
            {
                for (int j = 0; j < buys.Count; j++)
                {
                    if (distinct[i] == buys[j])
                    {
                        countOfProducts[i]++;
                    }
                }
            }
            int sch = 0;
            double countOfProductsToBuy = 0;
            for (int i = 0; i < distinct.Count; i++)
            {

                if (countOfProducts[i] >=3)
                {
                    sch++;
                }
                countOfProductsToBuy += (countOfProducts[i] - Math.Floor(countOfProducts[i] / 3d)) * distinct[i];
                
            }
            
            summ[count] = Convert.ToInt32(countOfProductsToBuy);

            return summ[count];

            
        }
    }
}
