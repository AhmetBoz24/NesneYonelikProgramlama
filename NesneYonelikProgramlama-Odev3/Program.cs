using System;
using System.Collections;

//soru 1
Console.WriteLine("soru1;\n");
ArrayList sayilar = new ArrayList();
sayilar.Add(5);
sayilar.Add(10);
sayilar.Add(15);
sayilar.Add(20);
sayilar.Add(25);

foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("________________");

//soru 2 

Console.WriteLine("soru2;\n");

Console.WriteLine("Bir cümle giriniz:");
string cümle = Console.ReadLine();
string[] kelimeler = cümle.Split(' ');
Console.WriteLine("toplam kelime sayısı:" + kelimeler.Length);

Console.WriteLine("________________");

//soru 3

Console.WriteLine("soru3\n");

ArrayList isimler = new ArrayList();

for (int i = 1; i < 6; i++)
{
    Console.WriteLine(i + ". isim ");
    isimler.Add(Console.ReadLine());
}
isimler.Sort();
Console.WriteLine("\nAlfabetik sırayla isimler:");
foreach (string isim in isimler)
{
    Console.WriteLine(isim);
}
Console.WriteLine("________________");

//soru 4

Console.WriteLine("soru4\n");

Console.WriteLine("Bir sayı giriniz:");
int sayı = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nFibonacci Dizisi");
int a = 0, b = 1, c;
for (int i = 0; i < sayı; i++)
{
    Console.Write(a + " ");
    c = a + b;
    a = b;
    b = c;
}
Console.WriteLine();
Console.WriteLine("________________");
//soru 5

Console.WriteLine("soru5\n");

int aklımdaki_sayı = 4;
while (true)
{
    Console.WriteLine("1-10 arasından bir sayı seçtim tahmin ediniz:");
    int tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin != aklımdaki_sayı)
    {
        Console.WriteLine("Yanlış tahmin!");
        Console.WriteLine("Tekrar deneyiniz\n");
    }
    else
    {
        Console.WriteLine("Doğru tahmin TEBRİKLER");
        break;
    }

}

Console.WriteLine("________________");
//soru6

Console.WriteLine("soru6\n");

string islem;
do
{
    Console.WriteLine("Yapmak istediğiniz işlemi seçin (+, -, *, /). Çıkmak için 'çıkış' yazın:");
    islem = Console.ReadLine();

    if (islem == "çıkış")
    {
        Console.WriteLine("Hesap makinesi kapanıyor...");
        break;
    }

    Console.WriteLine("Birinci sayıyı girin:");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("İkinci sayıyı girin:");
    int sayi2 = Convert.ToInt32(Console.ReadLine());
    switch (islem)
    {
        case "+":
            Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
            break;
        case "-":
            Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
            break;
        case "*":
            Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
            break;
        case "/":
            if (sayi2 != 0)
            {
                Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
            }
            else
            {
                Console.WriteLine("Hata: Sıfıra bölme yapılamaz!");
            }
            break;
        default:
            Console.WriteLine("Geçersiz işlem! Lütfen +, -, * veya / girin.");
            break;
    }

} while (true);
Console.WriteLine("________________");
//soru 7
Console.WriteLine("soru7\n");

int e = 2;
int toplam = 0;
List<int> girilen_sayılar = new List<int>();
while (e > 1)
{
    Console.WriteLine("Lütfen pozitif bir tam sayı giriniz.\nÇıkmak için 0 giriniz.");
    int girilen_değer = Convert.ToInt32(Console.ReadLine());

    if (girilen_değer == 0)
    {
        Console.WriteLine("Çıkış yapılıyor...");
        Console.WriteLine("Girdiğiniz Sayıların Toplamı:" + toplam);
        e = 0;
    }
    else
    {
        girilen_sayılar.Add(girilen_değer);
        toplam = toplam + girilen_değer;
    }
}

Console.WriteLine("\nGirilen Sayılar;");
for (int i = 0; i < girilen_sayılar.Count; i++)
{
    Console.WriteLine("Sayı " + (i + 1) + " = " + girilen_sayılar[i]);
}
