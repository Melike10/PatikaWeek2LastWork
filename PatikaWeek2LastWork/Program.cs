
//1- Console example
using System.Diagnostics.Metrics;

Console.WriteLine("-------1. Alıştırma-------- ");
Console.WriteLine("Merhaba!\n Nasılsın?\n İyiyim \n Sen nasılsın?\n");

//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
Console.WriteLine("-------2. Alıştırma-------- ");
string metin = "Sağlık ,huzur, başarı dolu bir yıl olması dileğiyle..";
int year = 2024;
Console.WriteLine(year +" 'in "+ metin);

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Console.WriteLine("-------3. Alıştırma-------- ");
Random random = new Random();
Console.WriteLine("Rastgele üretilen sayımız : "+random.Next());

//4-Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Console.WriteLine("-------4. Alıştırma-------- ");
Random rnd = new Random();
int sayi = rnd.Next();
int kalan = sayi % 3;
Console.WriteLine("Rastgele üretilen "+sayi +" sayısının 3 e bölümünden kalan "+kalan + " eşittir.");

//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.WriteLine("-------5. Alıştırma-------- ");
Console.WriteLine("Yaşınızı öğrenebilir miyim?");
byte yas = Convert.ToByte(Console.ReadLine());
if (yas > 18)
    Console.WriteLine("+");
else
    Console.WriteLine("-");

//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
Console.WriteLine("-------6. Alıştırma-------- ");

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}




//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.WriteLine("-------7. Alıştırma-------- ");
Console.WriteLine("Lütfen iki metinsel ifade giriniz!");
Console.Write("1. metin: ");
string txt1 = Console.ReadLine();
Console.Write("2. metin: ");
string txt2 = Console.ReadLine();
string tmp = txt1;
txt1 = txt2;
txt2 = tmp;
Console.WriteLine("Yazdığınız iki metin yer değiştirmiştir. Artık 1. metin  "+txt1+" olurken 2. metin de "+ txt2 +" olmuştur.");




//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
Console.WriteLine("-------8. Alıştırma-------- ");
 void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem();

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

Console.WriteLine("-------9. Alıştırma-------- ");
int Topla(int x, int y)
{
    return x + y;
}
int toplam = Topla(2, 3);
Console.WriteLine("2 ve 3 sayısının gönderdğim metodun çıkardığı sonuc "+ toplam);


//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
Console.WriteLine("-------10. Alıştırma-------- ");

goToKullanım:  Console.WriteLine("Lütfen true ya da false yazınız.");
string s = Console.ReadLine();

if(s.ToLower()=="true")
    Console.WriteLine(TrueOrFalse(true));  
else if (s.ToLower()=="false")
    Console.WriteLine(TrueOrFalse(false));
else
    goto goToKullanım;
string TrueOrFalse(bool text)
{
    if (text)
        return "doğru seçim";
    else
        return "yanlış seçim";
}


//3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
Console.WriteLine("-------11. Alıştırma-------- ");
int maxAge = MaxAge(new int[] {3,15,50});
Console.WriteLine("Yaşları 3,15,50 olan 3 kişinin en yaşlısı "+ maxAge);

int MaxAge(int[] yaslar)
   
{
    // ilk elemanı atıyoruz öncelikle
    int maxYas = yaslar[0];
    for (int i = 1; i < yaslar.Length; i++)
    {
        if (yaslar[i] > maxYas)
        { maxYas = yaslar[i]; }

        
    }
    return maxYas;
   
}




//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
Console.WriteLine("-------12. Alıştırma-------- ");
int EnBuyuk(params int[] sayilar)
        {
    int maxV = Int32.MinValue;
    if (sayilar.Length > 0)
        maxV= sayilar[0];
    foreach (int sayi in sayilar)
    {
        if (sayi > maxV)
            maxV = sayi;
    }

    Console.WriteLine("En Büyük Sayı: "+ maxV);
    return maxV;
}

    Console.WriteLine("Lütfen sayı giriniz!");
    Console.WriteLine("çıkmak istediğinizde Q'ya basmanız yeterlidir.");

while (true)
{
    if (Console.ReadLine() == "Q")
    { break; }

    EnBuyuk(Convert.ToInt32(Console.ReadLine()));
   
}






//13 - Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
Console.WriteLine("-------13. Alıştırma-------- ");
Console.Write("1. isim:");
string fn = Console.ReadLine();
Console.Write("2. isim:");
string fn2 = Console.ReadLine();
SwapNames(fn, fn2);

void SwapNames(string fn, string fn2)
{
    string tmp = fn2;
    fn2 = fn;
    fn= tmp;
    Console.WriteLine("Methodumuz ile isimlerin yerleri değiştirildi. 1. isim :"+fn+" 2. isim "+ fn2);
}


//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
Console.WriteLine("-------14. Alıştırma-------- ");
Console.WriteLine("Bir sayı giriniz");
int v = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Girilen sayı çift ise true değilse false bilgisi döndüren methodun sonucu "+ CiftOrTek(v));

bool CiftOrTek(int sayi)
{
    if (sayi % 2 == 0)
        return true;
    else 
        return false;
}




//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
Console.WriteLine("-------15. Alıştırma-------- ");
Console.WriteLine("Hız giriniz (km/sa):");
int sp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Zaman bilgisi giriniz (saat)");
int time = Convert.ToInt32(Console.ReadLine());
YolHesapla( sp , time);

void YolHesapla(int speed, int time)
{
  int yol = speed*time;
    Console.WriteLine("Gidilen yol = " + yol);
}

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
Console.WriteLine("-------16. Alıştırma-------- ");
Console.WriteLine("Yarıçap giriniz:");
int yr = Convert.ToInt32(Console.ReadLine());
AlanHesapla(yr);

void AlanHesapla(int y) {
    double alan = Math.Sqrt(y) * Math.PI;
    Console.WriteLine("dairenin alanı "+ alan);
}


//17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.
Console.WriteLine("-------17. Alıştırma-------- ");
string s2 = "Zaman bir GeRi SayIm";
Console.WriteLine(s2.ToLower() +"  "+ s2.ToUpper());

//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
Console.WriteLine("-------18. Alıştırma-------- ");
string s1 = "    Selamlar   ";
s1 = s1.Trim();
Console.WriteLine("    Selamlar   ");
Console.WriteLine(" metni bir değişkene atanarak ve trim özelliği kullanılarak başındaki ve sonundaki boşluklar kalıcı olarak silinmiştir. "+s1 );





