// en çok kullanılan 2 delegate
// Action<> --- geriye değer döndürmeyen metodları taşımak için kullanılır...
// Func<> --- geriye döndüren metodları taşımak için kullanılır...

using _08._11._2022;
using System.Collections;

List<int> sayilar = new List<int> { 1, 2, 324, 65, 78, 345, 37, 46 };

// LINQ(language  integrated query --- dile entegre edilmiş sorgu)
// LINQ to Object
// LINQ to SQL ---- Entity Framework
// LINQ to XML

// LINQ teknolojisi C# 3.0 ile gelmiştir..
//C# 3.0 ile gelen yenilikler ...(Yeniliklerin büyük kısmı LINQ için gelmiştir)

//1-var
//2-auto property
//3-object initializer
//4-colleciton initializer
//5-anonymous object
//6-extension methods
//7-expression tree
//8-lamda expression
var d1 = "İstanbul";
var d2 = 23.44;
var d3 = 33.33M;
var d4 = 23;
var d5 = true;
var d6 = 'A';
var d7 = new Personel();
var d8 = new string[] { "Ali", "Veli", "Selami" };
//ilk değer belli oluncaya kadar geçici olarak kullanılan bir ifadedir. İlk değer belli olduğunda tip sonradan değiştirilemez.
//var d1 = 1; string içine int tanımlanamıyor , tip değişmez
//c# 4.0 
dynamic d9 = "merhaba";
d9 = 12; //tip sonradan değişebilir

object sayi1 = 12;
//int sayi2 = sayi1;
// dynamicte tip dönüşümüne gerek gok
dynamic sayi3 = 12;
int sayi4 = sayi3;

//2- 
//public int Kitap { get; set; }

//3-object initializer
Kitap kitap = new Kitap();
kitap.KitapID = 2;
kitap.KitapAd = "kitap";
//bir nesneyi oluştururken ilk değer ataması yapmak için kullanılır

Kitap kitap2 = new Kitap() { KitapAd = "kitap", KitapID = 3 };
Kitap kitap3 = new Kitap { KitapAd = "kitap", KitapID = 3 };

//4- collection initializer

List<int> sayılar = new List<int>();
sayilar.Add(23);
List<int> sayılar2 = new List<int> { 2, 3, 4, 5, 6, 7, 8 };
List<int> sayılar3 = new List<int>() { 2, 3, 4, 5, 6, 7, 8 };

//5-Anonymous Object

var a1 = new { Id = 123, Ad = "İlker" }; // başında var olmalı , class oluşturur

//6- Extension Methods (Genişletme Metodları)
/*Genişletme metodları yazmak için uyulması gereken kurallar;
*1-Genişletme metodları static sınıf içerisinde yazılmalıdır
*2-Metodun kendisi de static olmalı (static sınıflardaki kural)
*3-Eklenecek olan metodlar hangi yapıya eklenecekse ilk parametre de this ile o yapıya iliştirilmelidir.. Eğer parametre gelmesi gerekiyorsa 2. 3. parametre olarak yaszılır, birinci ikinci parametre olarak kullanılır.
*
*/
string str = "Mesaj";

int sayi = 2;

Console.WriteLine(sayi.KupAl()); //this ile sayiyi parametreye gönderir
Console.WriteLine(str.TersCevir()); //classta yazılan parametre bağlama amaçlı kullanılır

//7-Expression Tree
Console.WriteLine(sayi.KareAl().KupAl().IkiyeBol().IstenilnSayiyaBol(3)); // c# 3.0 la geldi

//8-Lambda Exp

List<Kitap> kitaplar = new List<Kitap>() {
 new Kitap { KitapAd = "Denemeler", KitapID = 12,Kategori="Deneme",Fiyat=123 }
,new Kitap { KitapAd = "Dijital Kale", KitapID = 3,Kategori="Roman",Fiyat=33 }
,new Kitap { KitapAd = "Osmanlı Tarihi", KitapID = 9,Kategori="Tarih",Fiyat=1553 }
,new Kitap { KitapAd = "Büyük Umutlar", KitapID = 7,Kategori="Roman",Fiyat=473 }
};


foreach (Kitap book in kitaplar)
{
    if (book.Kategori == "Roman")
    {
        Console.WriteLine(book);
    }
}

//LINQ sorgulama becerisi
//LINQ to object

//1-SQL gibi ve
var sonuc = from k in kitaplar
            where k.Kategori == "Roman"
            select k;
Console.WriteLine();
Yaz(sonuc.ToList());
void Yaz(IEnumerable<Kitap> veri)
{
    foreach (Kitap book in veri)
    {
        Console.WriteLine(book);
    }
}

Console.WriteLine();
//2-Expression tree gibi yazılabilir.
Yaz(kitaplar.Where(k => k.Kategori == "Roman"));
Console.WriteLine();
//fiyata göre sırala
Yaz(kitaplar.OrderBy(k => k.Fiyat));

var sounc2 = from k in kitaplar
             orderby k.Fiyat descending
             select k;
Console.WriteLine();
Yaz(sounc2.ToList());

//----------------

//soru sonuc nedir
int ID = 12;
var sonuc3 = from k in kitaplar
             where k.KitapID == ID
             select k;
ID = 9;
Console.WriteLine();
Yaz(sonuc3.ToList());
//LINQ sorguları Deffered Modele göre çalışır 