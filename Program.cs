using System;

namespace MANGMOTCHIEU
{
    class TinhTongPhanTuMang
    {
        static void Main(string[] args)
        {
            int[] mang = new int[5];
            mang[0] = 2;
            mang[1] = 5;
            mang[2] = 9;
            mang[3] = 6;
            mang[4] = 7;
            
            int tong = 0;
            for(int i= 0; i<5; i++)
            {
                tong += mang[i];
            }
            Console.WriteLine(tong);
        }
    }
}