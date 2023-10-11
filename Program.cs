namespace SehirTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Şehir Tahmin Oyunu -------");

            string[] sehirler =
            {
                "Van",  "Ankara",  "Balıkesir", "İstanbul", "Bursa"
            };

            Random rnd = new Random();

            

            

            int pcSkor = 0;

            int oyuncuSkor = 0;

            bool durum = true;

            while (durum)
            {
                if (durum)
                {
                    int index = rnd.Next(0, sehirler.Length);
                    string sehir = sehirler[index];

                    Console.WriteLine("Bilgisayar şehir seçti, tahmin et bakalım hangi şehir\n");
                    Console.WriteLine("5 olan kazanır :)\n");

                    foreach (var item in sehirler)
                    {
                        Console.Write(item+"  ");
                    }
                    Console.Write("\n\nBir şehir giriniz : ");

                    string girilenSehir = Console.ReadLine();

                    Thread.Sleep(1000);

                    Console.WriteLine("Sonucu Görmeye Hazır mısınızzzz ?");

                    Thread.Sleep(1000);

                    Console.Beep();

                    girilenSehir = girilenSehir.Substring(0, 1).ToUpper() + girilenSehir.Substring(1).ToLower();

                    if (girilenSehir == sehir)
                    {
                        Console.WriteLine("Tebrikler bildiniz");

                        oyuncuSkor++;
                        Console.WriteLine();

                        Console.WriteLine($"Oyuncu Skor : {oyuncuSkor} vs. Pc Skor : {pcSkor}\n");
                    }
                    else
                    {
                        Console.WriteLine($"Bilemediniz, piyangodan çıkan şehir : {sehirler[index]}\n");

                        pcSkor++;
                        Console.WriteLine();

                        Console.WriteLine($"Oyuncu Skor : {oyuncuSkor} vs. Pc Skor : {pcSkor}\n");

                    }

                    if (pcSkor == 5 || oyuncuSkor==5)
                    {
                        durum = false;
                    }
                }
            }

        }
    }
}