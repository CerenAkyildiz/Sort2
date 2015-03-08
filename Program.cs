using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort2{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[100];
            int istenenEleman;
            Random rastgele = new Random();
            for (int i = 0; i < 100; i++)
            {
                int sayi = rastgele.Next(1, 500);
                dizi[i] = sayi;

            }
            Console.WriteLine("Sıralanmamış Dizi :");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i] + " ");
            }
            Console.Write("Kaçıncı Eleman : ");
            istenenEleman = Convert.ToInt32(Console.ReadLine());
            int gecici = 0;

            for (int i = 0; i < istenenEleman; i++)
            {
                for (int j = 0; j < istenenEleman; j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        gecici = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < istenenEleman; j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        gecici = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }
            Console.WriteLine("Sıralanmış Dizi :");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }

    }
}
