void Ayır()
{
    Console.WriteLine("-*-*-*-*-*------------------------<>---------------------------*-*-*-*-*-");
}
Ayır();
/*
 1 - Aşağıdaki çıktıyı yazan bir program.

Merhaba
Nasılsın ?
İyiyim
Sen nasılsın ?
*/

Console.WriteLine("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen nasılsın ?");
Ayır();
//2 - Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

string isim = "Burak";
int yas = 24;

Console.WriteLine($"İsim: {isim} Yas: {yas}");
Ayır();
//3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Random rnd = new Random();
int sayı = rnd.Next(1, 100);
Console.WriteLine($"Sayı: {sayı}");
Ayır();
//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random rnd2 = new Random();
double sayı2 = rnd2.Next(1, 10);
double kalan = sayı2 % 3;
Console.WriteLine("Kalan:" + kalan);
Ayır();
//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.Write("Kaç Yaşındasınız:");
int yas2 = Convert.ToInt32(Console.ReadLine());
if (yas2 > 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}
Ayır();
//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem");
}
Ayır();
//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("İlk metini giriniz: ");
string metin1 = Console.ReadLine();
Console.WriteLine("İkinci metini giriniz:");
string metin2 = Console.ReadLine();
string degis = metin1;
metin1 = metin2;
metin2 = degis;
Console.WriteLine("Metin1: " + metin1 + " ," + " Metin2: " + metin2);
Ayır();
// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();

Ayır();

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

static int Topla(int a, int b)
{
    return a + b;
}

Console.WriteLine(Topla(8, 2));
Ayır();

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

static string BoolToString(bool input)
{
    if (input)
    {
        return "Evet";
    }
    else
    {
        return "Hayır";
    }
}


Console.Write("Lütfen true veya false girin: ");
string userInput = Console.ReadLine().ToLower();

bool boolValue;
if (bool.TryParse(userInput, out boolValue))
{
    string result = BoolToString(boolValue);
    Console.WriteLine($"Girdiğiniz değerin karşılığı: {result}");
}
else
{
    Console.WriteLine("Geçersiz giriş. Lütfen 'true' veya 'false' girin.");
}

Ayır();

//  11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

static int EnBuyukYas(int yas1, int yas2, int yas3, out int enBuyuk)
{
    enBuyuk = Math.Max(yas1, Math.Max(yas2, yas3));

    if (enBuyuk == yas1)
    {
        Console.WriteLine("En büyük yaş: " + yas1);
    }
    else if (enBuyuk == yas2)
    {
        Console.WriteLine("En büyük yaş: " + yas2);
    }
    else
    {
        Console.WriteLine("En büyük yaş: " + yas3);
    }

    return enBuyuk;
}

Console.Write("İlk yaş'ı giriniz:");
int age1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci yaş'ı giriniz:");
int age2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü yaş'ı giriniz:");
int age3 = Convert.ToInt32(Console.ReadLine());

int enBuyuk;

EnBuyukYas(age1, age2, age3, out enBuyuk);

Ayır();

//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

static int EnBuyukSayiyiBul()
{
    int enBuyukSayi = int.MinValue;
    Console.WriteLine("Sayıları giriniz, çıkmak için q yazınız");

    while (true)
    {
        string giris = Console.ReadLine();
        if (giris == "q")
        {
            break;
        }
        else
        {
            int number;
            bool isNumber = int.TryParse(giris, out number);
            if (isNumber)
            {
                if (number > enBuyukSayi)
                {
                    enBuyukSayi = number;
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz veya çıkmak için 'q' yazınız.");
            }
        }
    }

    Console.WriteLine($"En büyük sayı: {enBuyukSayi}");
    return enBuyukSayi;
}

EnBuyukSayiyiBul();
Ayır();
//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

static (string, string) YerDegistir(string isim1, string isim2)
{
    return (isim2, isim1);
}

Console.WriteLine("İlk ismi girin:");
string isim1 = Console.ReadLine();
Console.WriteLine("İkinci ismi girin:");
string isim2 = Console.ReadLine();

Console.WriteLine($"Metottan önce ; İsim1: {isim1} , İsim2: {isim2}");

(isim1, isim2) = YerDegistir(isim1, isim2);

Console.WriteLine($"Metottan sonra ; İsim1: {isim1} , İsim2: {isim2}");
Ayır();
//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

static bool TekMiCiftMi(int sayi)
{
    return sayi % 2 != 0; // Tek ise true, çift ise false döner
}

Console.Write("Bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

bool sonuc = TekMiCiftMi(sayi);

Console.WriteLine(sonuc ? "Tek" : "Çift");
Ayır();
//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

//x=v*t

static int GidilenYol(int hiz, int zaman)
{
    return hiz * zaman;
}

Console.Write("Hızı giriniz (km/saat): ");
int hiz = Convert.ToInt32(Console.ReadLine());

Console.Write("Zamanı giriniz (saat): ");
int zaman = Convert.ToInt32(Console.ReadLine());

if (hiz < 0 || zaman < 0)
{
    Console.WriteLine("Hata: Hız ve zaman negatif olamaz.");
}
else
{
    int yol = GidilenYol(hiz, zaman);
    Console.WriteLine($"Gidilen yol = {yol} km");
}
Ayır();
//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

static double DaireAlan(double yariCap)
{
    return Math.PI * yariCap * yariCap;
}

Console.Write("Yarı çap giriniz (cm): ");
double yariCap = Convert.ToDouble(Console.ReadLine());

double alan = DaireAlan(yariCap);

Console.WriteLine($"Daire Alanı: {alan:F2} cm²");
Ayır();
//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string metin4 = "Zaman bir GeRi SayIm";

Console.WriteLine("Küçük harf hali :" + metin4.ToLower() + "\n" + "Büyük harf hali:" + metin4.ToUpper());
Ayır();
//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string metin6 = "    Selamlar   ";
string bosluksuzMetin = metin6.Trim();
Console.WriteLine(bosluksuzMetin);
Ayır();