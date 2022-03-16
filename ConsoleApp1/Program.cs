using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score;
            Console.Write("請輸入分數:");
            score = Convert.ToInt32(Console.ReadLine());
            string result = score >= 60 ? "及格" : "不及格";
            Console.WriteLine("同學你這次{0}",result);
            Console.ReadLine();
        }
    }
}
