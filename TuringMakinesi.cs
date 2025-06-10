using System;

class TuringMakinesi
{
    static void Main()
    {
        Console.Write("Lütfen 4 haneli PIN kodunuzu girin: ");
        string kullaniciPIN = Console.ReadLine();

        string sistemPIN = "1234"; // sabit sistem pini 
        string bant = "#" + kullaniciPIN + "#" + sistemPIN + "#";

        char[] bantDizi = bant.ToCharArray(); // bant dizisi karakter dizisine çevriliyor 

        int head = 1;
        int sistemBaslangic = bant.IndexOf('#', head) + 1;// sistem pininin başladığı yeri buluyoruz 
        bool hataVar = false;

       
        for (int i = 0; i < 4; i++)
        {
            char kullaniciKarakter = bantDizi[head + i];
            char sistemKarakter = bantDizi[sistemBaslangic + i];

            // Eşleşme kontrolünü yapıp ekrana yazdırıyoruz
            Console.WriteLine($"Adım {i + 1}: Kullanıcı PIN: {kullaniciKarakter}, Sistem PIN: {sistemKarakter}");

            if (kullaniciKarakter != sistemKarakter)
            {
                hataVar = true;
                break;
            }

            // Eşleşen karakterleri Turing makinesinde işlenmiş  gibi işaretliyoruz
            bantDizi[head + i] = 'X';
            bantDizi[sistemBaslangic + i] = 'Y';

            
            Console.WriteLine("Bant: " + new string(bantDizi));// bantın durunu eekrana yazdır
        }
        if (hataVar)
        {
            Console.WriteLine("Şifre hatalı, REDDEDİLDİNİZ");
        }
        else
        {
            Console.WriteLine("Şifre doğru, KABULEDİLDİNİZ");
        }
    }
}
