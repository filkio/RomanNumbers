using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            string res = "";
            int count = 0;

            while (num >= 1000)
            {
                res += "M";
                num -= 1000;
            }

            while (num >= 900)
            {
                res += "CM";
                num -= 900;
            }

            if (num >= 500)
            {
                res += "D";
                num -= 500;
                count = (num / 100);
                for (int i = 0; i < count; i++)
                {
                    res += "C";
                    num -= 100;
                  
                }
              
            }

            while (num >= 400)
            {
                res += "CD";
                num -= 400;
            }

            if (num >= 100)
            {
                count = num / 100;
                for (int i = 0; i < count; i++)
                {
                    res += "C";
                    num -= 100;
                }
            }

            while (num >= 90)
            {
                res += "XC";
                num -= 90;
            }

            if (num >= 50)
            {
                res += "L";
                num -= 50;
                count = (num / 10) ;
                for (int i = 0; i < count; i++)
                {
                    res += "X";
                    num -= 10;
                }
            }

            while (num >= 40)
            {
                res += "XL";
                num -= 40;
            }

            if (num >= 10)
            {
                count = num / 10;
                for (int i = 0; i < count; i++)
                {
                    res += "X";
                    num -= 10;
                }
            }

            while (num == 9)
            {
                res += "IX";
                num -= 9;
            }

            if (num >= 5)
            {
                res += "V";
                num -= 5;
                count = num ;
                for (int i = 0; i < count; i++)
                {
                    res += "I";
                    num -= 1;
                }
            }
            while (num == 4)
            {
                res += "IV";
                num -= 4;
            }

            if (num >= 1)
            {
                count = num;
                for (int i = 0; i < count; i++)
                {
                    res += "I";
                    num -= 1;
                }
            }
            Console.WriteLine($"Результат {res}");
            Console.ReadKey();


        }
















        
        
    }
}
