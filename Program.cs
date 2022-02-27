using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine();
            
            byte b=5; //1byte
            sbyte c= 5; // 1 byte
            short s = 5; //2 byte
            ushort us = 5; // 2 byte

            Int16 i16 = 55; // 2 byte
            int i =2; // 4 byte
            Int32 i32=5; // 4 byte
            Int64 i64=5; // 8 byte

            uint ui =4; // 4 byte
            long lo =4; // 8 byte
            ulong l =4; // 8 byte

            //Reel sayılar
            float f =4; // 4 byte
            double d =5; // 8 byte
            decimal de=16; //16 byte

            char ch ='2';
            string st="derya";

            bool bl= true;

            DateTime dt=DateTime.Now;
            Console.WriteLine(dt);
        }
    }
}
