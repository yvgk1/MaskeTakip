
//static void Degiskenler()
//{
//    string isim = "Emre";

//    for (int i = 0; i < 2; i++)
//    {
//        Console.WriteLine(isim);
//    }

//    double tutar = 10000;
//    Console.WriteLine(tutar * 1.18);
//    int sayi = 100;
//    bool girisYapmismi = false; //kullnaıcı giriş yapıp yapmadığını kontrol edebiliriz.

//    string ad = "Emre";
//    string soyad = "Topal";
//    int dogumYili = 1996;
//    long tcNo = 12345678910;
//}
using Business.Concrete;
using Entities.Concrete;
using System.Runtime.InteropServices;
using System.Security.Claims;

public class Workaround()
{
    static void Main(string[] args)
    {
        SelamVer("emre");
        SelamVer("ahmet");
        SelamVer("ayşe");
        SelamVer();

        int sonuc = Topla(6, 58);

        //Arrays
        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Emre";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";

        ogrenciler = new string[4];
        ogrenciler[3] = "Süleyman";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        //stringler referans tip , sayılar (int double float bool)değer tiplerin hepsi stackde
        string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);
        

        Person person1 = new Person();
        person1.FirstName = "Engin";
        person1.LastName = "Demiroğ";
        person1.DateOfBirthYear = 1990;
        person1.NationalIdentity = 123;
        

        Person person2 = new Person();
        person2.FirstName = "Murat";

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        //MyList  ile yenisehirler1 array oluştur

        List<string> yeniSehirler1 = new List<string>{"Ankara 1", "İstanbul 1", "İzmir 1" };
        yeniSehirler1.Add(item: "Adana 1");
        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }
        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();
    }
   
    static void SelamVer(string isim = "İsimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }
    static int Topla(int sayi1 = 5, int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam " + sonuc.ToString());
        return sonuc;
    }
}


public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}


