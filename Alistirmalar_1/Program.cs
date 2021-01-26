using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1) Dictionary sinifi icinde sizin belirleyeceginiz bir key e uygun olarak deger saklar
             2) key turunun belirlenmesi sarttir
              
            */
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            // veri ekliyoruz 

            AdYas.Add("Sinem", 2011);
            AdYas.Add("Ihsan", 2008);
            AdYas.Add("Arkadas", 2007);

            foreach (var kisi in AdYas)
            {
                Console.WriteLine(kisi);
            }

            // deger sayma ozelligi var
            int elemanSayisi = AdYas.Count;
            Console.WriteLine();
            Console.WriteLine("Eleman sayisi : " + elemanSayisi);

            // silme ozelligi var
            AdYas.Remove("Arkadas");
            Console.WriteLine();

            foreach (var kisi in AdYas)
            {
                Console.WriteLine(kisi);
            }

            Console.WriteLine("Eleman sayisi : " + AdYas.Count);

        }
    }
}
