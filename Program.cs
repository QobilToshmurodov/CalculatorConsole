using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        //1. O’zingiz yozgan kalkulyator dasturingizga quyidagi o’zgartirishlarni kiritib, uni takomillashtiring
        //2. Berilgan sonni darajaga oshirish, hamda uningildizni topish;
        //3. Hisoblab topilgan natijani matn ko’rinishida qaytarish.Masalan, agar natija 103 bo’lsa,
        //kalkulyator natijani “bir yuz uch” ko’rinishida qaytarsin.

        static void Main(string[] args)
        {
            while (true)
            {
                string operation = string.Empty;
                while (!new[] { "+", "-", "*", "/","^","√" }.Contains(operation))
                {
                    Console.WriteLine("Quyidagi amallardan birini kiriting: \n+ \n- \n* \n/ \n^ \n√");
                    operation = Console.ReadLine();
                }

                int firstnumber = GetNumberValid("Brinchi sonni kiriting");
                int secondnumber = GetNumberValid("Ikkinchi sonni kiriting");

                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = firstnumber + secondnumber;
                        break;

                    case "-":
                        result = firstnumber - secondnumber;
                        break;

                    case "*":
                        result = firstnumber * secondnumber;
                        break;

                    case "/":
                        result = firstnumber / secondnumber;
                        break;
                    case "^":
                        result =Math.Pow(firstnumber,secondnumber);
                        break;
                    case "√":
                        result=Math.Pow(firstnumber,1/secondnumber);
                        break;

                    default:
                        throw new Exception("Mavjud bo'lmagan amal");
                }
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}"); 
            }
        }

        private static int GetNumberValid(string displaytext)
        {
            int number = 0;
            bool isNumberValid = false;

            while (!isNumberValid)
            {
                Console.WriteLine(displaytext);
                isNumberValid = int.TryParse(Console.ReadLine(), out number);
            }

            return number;
        }
    }
}
