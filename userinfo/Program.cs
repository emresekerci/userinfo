Console.WriteLine("Lütfen asagidaki bilgileri giriniz :");
Console.Write("T.C. Kimlik Numarasi : ");
 
  long idinfo = Convert.ToInt64(Console.ReadLine()); //kullanıcıdan alınacak tc kimlik numarası sayısal değerde long(long veri tipi 19 basamağa kadar tam sayı tutar ve 32 bitten büyük olduğu için convert işleminde 64 bit olarak tanımlanır) olarak tutulup Consone.Readline() yapısına uygun olarak convert edildi.
Console.Write("Adi : ");
string name  = Console.ReadLine();
Console.Write("Soyadi : ");
 string surname = Console.ReadLine(); //kullanıcıdan string değerde Adı ve Soyadı alındı.
Console.Write("Telefon Numarasi : ");
 long phonenum = Convert.ToInt64(Console.ReadLine()); 
Console.Write("Yas : ");
 int age  = Convert.ToInt32(Console.ReadLine());
Console.Write("Ilk Aldigi Urunun Fiyati : ");
 int firstprsc = Convert.ToInt32(Console.ReadLine());
Console.Write("Son Aldigi Urunun Fiyati : ");
int secondprsc = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("--------------------------------------");

Console.WriteLine(idinfo + " Tc numarali " + name +  " " + surname + "" + " isimli kisi icin kayit olusturulmustur."); // kod satırında değişken + " " ifadesiyle önceden kullanıcıdan alınan değer çağırılır.

Console.WriteLine(phonenum + " " + " telefon numarasina bildirim mesaji gönderilmistir.");
int totalprsc = firstprsc + secondprsc;
Console.WriteLine((totalprsc) + " toplam harcama karsiligi kazanilan 10% patika puan miktari -> " + (totalprsc * 0.1) + " TL'dir");