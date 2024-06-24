using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diemsinhvien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao diem cua sinh vien: ");
            float score = float.Parse(Console.ReadLine());

            if (score < 0 || score > 10)
            {
                Console.WriteLine("Error! ");
            }
            else
            { 




            if (score < 5)
            {
                Console.WriteLine("Truot mon");
            }
            else if (5 <= score && score < 6)
            {
                Console.WriteLine("Hoc sinh trung binh");
            }

            else if (6 <= score && score < 8)
            {
                Console.WriteLine("Hoc sinh kha");
            }

            else if (8 <= score && score < 9)
            {
                Console.WriteLine("Hoc sinh gioi");
            }
            else
            {
                Console.WriteLine("Hoc sinh xuat sac");
            }

        }
    }
}
