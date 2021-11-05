using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VardanianHw_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            Console.Write("Input size: ");
            size = Convert.ToInt32(Console.ReadLine());
            if (size <= 0)
            {
                Console.WriteLine("Невозможно создать массив<=0 ");
            }
            else
            {
                int[] nums = new int[size];
                object[] even = new object[size];
                object[] odd = new object[size];
                byte evenIndex = 0;
                byte oddIndex = 0;
                string alphavit = "abcdefghijklmnopqrstuvwxyz";
                int amountOfUpperCaseArr1 = 0;
                int amountOfUpperCaseArr2 = 0;
                Random rnd = new Random();

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = rnd.Next(1, 27);
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 1)
                    {
                        odd[oddIndex] = nums[i];
                        oddIndex++;
                    }
                    else
                    {
                        even[evenIndex] = nums[i];
                        evenIndex++;
                    }
                }
                Array.Resize(ref even, evenIndex);
                Array.Resize(ref odd, oddIndex);

                for (int i = 0; i < even.Length; i++)
                {
                    object b = even[i];
                    int c = Convert.ToInt16(b);
                    string tmp = alphavit[c - 1].ToString();
                    if (tmp == "a" || tmp == "e" || tmp == "i" || tmp == "d" || tmp == "h" || tmp == "j")
                    {
                        string innerTemp = tmp.ToUpper();
                        tmp = innerTemp;
                        even[i] = tmp;
                        amountOfUpperCaseArr1++;
                    }
                    {
                        even[i] = tmp;
                    }
                }

                for (int i = 0; i < odd.Length; i++)
                {
                    object b = odd[i];
                    int c = Convert.ToInt16(b);
                    string tmp = alphavit[c - 1].ToString();
                    if (tmp == "a" || tmp == "e" || tmp == "i" || tmp == "d" || tmp == "h" || tmp == "j")
                    {
                        string innerTemp = tmp.ToUpper();
                        tmp = innerTemp;
                        odd[i] = tmp;
                        amountOfUpperCaseArr2++;
                    }
                    else
                    {
                        odd[i] = tmp;
                    }
                }

                if (amountOfUpperCaseArr1 > amountOfUpperCaseArr2)
                {
                    Console.WriteLine("В первом массиве больше чисел в верхнем регистре");
                }
                else
                {
                    Console.WriteLine("Во втором массиве больше чисел в верхнем регистре");
                }
                Console.Write("Первый массив:");

                foreach (var item in even)
                {
                    Console.Write(item + " ");
                }
                Console.Write("\nВторой массив:");
                foreach (var item in odd)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
