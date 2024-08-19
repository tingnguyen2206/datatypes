using System;
using System.Numerics;
class datatypes1
{
    static void Main(string[] args)
    {
        bai_01();
        bai_02();
    }   
        static void bai_01() //bai1
        {
            Console.WriteLine("Nhap do C");
            float C = Convert.ToSingle(Console.ReadLine());
            float K = C + 273;
            float F = C * 18 / 10 + 32;
            Console.WriteLine("{0} in C = {1} in K", C, K);
            Console.WriteLine("{0} in C = {1} in F", C, F);
        }
        static void bai_02()
        {
            Console.WriteLine("Nhap ban kinh R cua hinh cau");
            float R = Convert.ToSingle(Console.ReadLine());
            float surface = (float)(4 * Math.PI * Math.Pow(R, 2));
            float volume = (float)(4 / 3 * Math.PI * Math.Pow(R, 4));
            Console.WriteLine(" Dien tich hinh cau: {0}", (float)surface);
            Console.WriteLine("The tic hinh cau:{0}", (float)volume);
        }
    }


    
