using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilariAlistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı Kodu : ");
            string kulllaiciKodu = Console.ReadLine();

            switch (kulllaiciKodu)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin yetkisine sahipsiniz");
                    break;

                case "DD":
                    Console.WriteLine("Güçlü kullanıcı yetkisine sahipsiniz");
                    break;

                case "FF":
                case "EE":
                case "GG":
                    Console.WriteLine("Standart kullanıcı yetkisine sahipsiniz");
                    break;

                default:
                    Console.WriteLine("Hatalı kullanıcı kodu");
                    break;

            }

            Console.WriteLine("İyi günler dileriz..");
            Console.ReadLine();
        }
    }
}
