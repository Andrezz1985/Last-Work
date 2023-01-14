using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string PrintM(string[] array)
            {
                string result = string.Empty;
                result = "[ ";
                for (int i = 0; i < array.Length; i++)
                {
                    result += $"{array[i],1}";
                    if (i < array.Length - 1) result += ", ";
                }
                result += " ]";
                return result;
            }

            int InputN(string input)
            {
                Console.Write(input);
                int outt = Convert.ToInt32(Console.ReadLine());
                return outt;
            }








            

        }
    }
}
