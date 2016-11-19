using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_S2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean secim = true;
            while (secim == true)
            {
                Console.WriteLine("işlem tipini giriniz (+,-,*,/) : ");
                char tip = Convert.ToChar(Console.Read());
                switch (tip)
                {
                    case '+':
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int J = 1; J <= 10; J++)
                            {
                                Console.WriteLine("*");
                            }
                        }

                        break;
                    case '-':
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("-");
                        }
                        break;

                    case '/':
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("/");
                        }
                        break;

                    case '*':
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("*");
                        }
                        break;

                    default:

                        Console.WriteLine("Hatalı Giriş Yaptınız !!!");

                        break;
                }

                Console.Write("Devam Etmek istiyormusunuz ?(E/H)");
                string soru = Console.ReadLine();
                if (soru == "H")
                {
                    secim = false;
                }

                else
                {
                    secim = true;

                }

            }
        }
    }
}
