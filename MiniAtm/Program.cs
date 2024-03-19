using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıya soracağız hangi işlemi yapmak istediğini

            //1.seçim Bakiye göster
            //2.seçim Para yatır
            //3.seçim Para çek
            //3.seçim Çıkış yap



            Console.WriteLine("ATM ye hoş gelidiniz lütfen yapmak istediğiniz işlemi seçiniz :");

            Console.WriteLine("1.BAKİYE GÖSTER");
            Console.WriteLine("2.PARA YATIR");
            Console.WriteLine("3.PARA ÇEK");
            Console.WriteLine("4 ÇIKIŞ YAP");

            string secim = Console.ReadLine();
            int bakıye = 2500;

            while (true)
            {
                if (secim == "1")
                {
                    Console.WriteLine("Güncel bakiyeniz =" + " " + bakıye);
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz :");
                    int parayatırma = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Para yatıma işlemi gerçekleşti Güncel bakiyeniz =" + " " + (bakıye + parayatırma));
                }
                else if (secim == "3")
                {
                    Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz :");
                    int paracek = Convert.ToInt32(Console.ReadLine());
                    if (paracek < bakıye)
                    {
                        Console.WriteLine("Yetersiz bakiye ");
                    }
                    Console.WriteLine("Para çekme işlem gerçekleşti Güncel Bakiyeniz = " + " " + (bakıye - paracek));
                }
                else if (secim == "4")
                {
                    Console.WriteLine("Çıkış yapıldı ");
                    Console.WriteLine("İyi günler TEKRAR BEKLERİZ :)");
                }
                Console.ReadLine();
                break;
            }



        }
    }
}
