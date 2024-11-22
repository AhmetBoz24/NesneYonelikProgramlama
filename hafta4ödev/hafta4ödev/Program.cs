
class Program
{

    //SORU1 Matematiksel Hesaplama Yapan Parametresiz ve Geriye Değer Döndüren Metot
    public static double üçgenalan(double sayı1, double sayı2)
    {
        return (sayı1 * sayı2) / 2;
    }

    //SORU2 2. Dizideki En Büyük Değeri Bulan Parametreli ve Geriye Değer Döndüren Metot
    public static int maxdeger(int[] dizi)
    {
        int max = dizi[0];
        foreach (int sayı in dizi)
        {
            if (sayı > max)
            {
                max = sayı;
            }

        }
        return max;
    }
    //SORU3  Aşırı Yüklenmiş (Overloaded) Metot ile Farklı Türdeki Verilerin Toplamını Bulma
    public static int toplamayap(int sayı1, int sayı2)
    {
        return sayı1 + sayı2;
    }
    public static double toplamayap(double sayı1, double sayı2)
    {
        return sayı1 + sayı2;
    }
    public static int toplamayap(int sayı1, int sayı2, int sayı3)
    {
        return sayı1 + sayı2 + sayı3;
    }
    //SORU4  Recursive Metot ile Fibonacci Dizisi Hesaplama
    public static int fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return fibonacci(n - 1) + fibonacci(n - 2);
    }
    //SORU5  Params ile Sınırsız Sayıda Parametre Alarak Ortalama Hesaplama
    public static double ortalamahesapla(params double[] dizi)
    {
        double toplam = 0;
        foreach (double say in dizi)
        {
            toplam += say;
        }
        return toplam / dizi.Length;

    }
    //SORU6  Dizi Elemanlarını Toplayan ve Filtreleme Şartı Ekleyen Metot
    public static int filtrelitoplam(int[] dizi, int filtre)
    {
        int toplam = 0;
        foreach (int say in dizi)
        {
            if (say > filtre)
            {
                toplam += say;
            }
        }
        return toplam;
    }
    //SORU7.Seçmeli (Optional) Parametre ile Belirli Yaştan Sonraki Yılları Sayma
    public static int yasfarkınıbul(int yas = 18)
    {
        return yas - 18;
    }

    //SORU8  Geriye Koleksiyon Döndüren ve Veriyi Filtreleyen Metot
    public static List<string> beştenbüyüklerifiltreleme(string[] dizi)
    {
        List<string> sonuclist = new List<string>();
        foreach (string say in dizi)
        {
            if (say.Length > 5)
            {
                sonuclist.Add(say);
            }
        }
        return sonuclist;
    }







    static void Main(string[] args)
    {
        //SORU1
        Console.WriteLine("SORU 1");
        Console.WriteLine("üçgenin tabanını giriniz:");
        double taban = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("üçgenin yüksekliğini giriniz;");
        double yükseklik = Convert.ToDouble(Console.ReadLine());

        double alan = üçgenalan(taban, yükseklik);
        Console.WriteLine("alan= " + alan);



        //SORU2
        Console.WriteLine("\nSORU2");
        int[] sayılar = { 11, 33, 21, 65, 87, 98 };
        int max = maxdeger(sayılar);
        Console.WriteLine("dizideki en büyük değer: " + max);


        //SORU3
        Console.WriteLine("\nSORU3");
        double toplam1 = toplamayap(5, 2);
        Console.WriteLine("ilk işlemin toplaması=" + toplam1);
        double toplam2 = toplamayap(5.1, 2.3);
        Console.WriteLine("ikinci işlem toplaması=" + toplam2);
        double toplam3 = toplamayap(3, 4, 5);
        Console.WriteLine("3.işlem toplaması=" + toplam3);

        //SORU4
        Console.WriteLine("\nSORU4");
        Console.WriteLine("öğrenmek istediğiniz fibonacci sırasının sayısını giriniz : ");
        int sayı = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{sayı}. Fibonacci sayısı: {fibonacci(sayı)}");

        //SORU5
        Console.WriteLine("\nSORU5");
        double ortalama1 = ortalamahesapla(10.5, 20.7, 30.3, 40.8);
        Console.WriteLine("Ortalama 1: " + ortalama1);

        double ortalama2 = ortalamahesapla(15.2, 25.5, 35.1);
        Console.WriteLine("Ortalama 2: " + ortalama2);

        double ortalama3 = ortalamahesapla(5.0);
        Console.WriteLine("Ortalama 3: " + ortalama3);

        //SORU6
        Console.WriteLine("\nSORU6");
        int[] filtrelidizi = { 2, 3, 4, 5, 10, 10, 12 };
        int filtre = 5;
        int toplamsonuc = filtrelitoplam(filtrelidizi, filtre);
        Console.WriteLine("filtre değerinden büyük olan sayıların toplamı:" + toplamsonuc);

        //SORU7 
        Console.WriteLine("\nSORU7");
        int fark1 = yasfarkınıbul();
        Console.WriteLine("yaş 18den ne kadar fazla:" + fark1);
        int fark2 = yasfarkınıbul(25);
        Console.WriteLine("25 yaşındaki insanla 18 yaşındakinin yaş farkı::" + fark2);
        int fark3 = yasfarkınıbul(31);
        Console.WriteLine("31 yaşındaki insanla 18 yaşındakinin yaş farkı:" + fark3);

        //SORU8
        Console.WriteLine("\nSORU8");
        string[] dizi = { "istanbul", "ankara", "izmir", " van", "erzincan" };
        List<string> beştenbüyükkelime = beştenbüyüklerifiltreleme(dizi);
        Console.WriteLine("5 harfden büyük kelimeler: ");
        foreach (string kelime in beştenbüyükkelime)
        {
            Console.WriteLine(kelime);
        }

        Console.ReadKey();
    }


}
