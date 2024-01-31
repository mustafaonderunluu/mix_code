// See https://aka.ms/new-console-template for more information
using System;



//Metot Mantığı 

//static void Main(string[] args)
//{
//    int x = 5;
//    Console.WriteLine("X in önceki hali :" + x);
//    artir( x);
//    Console.WriteLine("X in sonraki hali :" + x);

//    void artir( int x)
//    {
//        x++;
//        Console.WriteLine("Metot İçinde ki hali :" + x);
//    }
//}

//sayi rakamlarin toplamı (Metot değil)


Console.WriteLine("Sayı giriniz : ");
int sayi=Convert.ToInt32(Console.ReadLine());
static int rakamlarınToplami(int sayi)
{
    int gecici = sayi;
    int toplam = 0;
    while (gecici != 0) {


        int rakam = gecici % 10;
        toplam += rakam;
       gecici = gecici / 10;


    }
    return toplam;
}
Console.WriteLine(sayi + "Rakamların Toplami :" + rakamlarınToplami(sayi));
Console.ReadLine();