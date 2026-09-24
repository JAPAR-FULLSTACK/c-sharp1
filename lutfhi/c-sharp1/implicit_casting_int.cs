using System;

/*
1.implicit Casting (Bertahap)

-implicit casting adalah sebuah konversi tipe data yang dilakukan secara otomatis 
oleh compiler
-biasanya terjadi  ketika  kita mengonversi tipe data yang lebih kecil  ke tipe data yang besar .
-Contoh: byte --> short --> int --> long --> float --> double  --> decimal
- Kentungan  dari implicit Casting adalah 
  A.tidak perlu menulis code  tambahan  untuk  melakukan konversi  karena kompiler 
    akan  dilakukan secara otomatis .
  B.mengurangi kemmungkinan kesalahan konversi  tipe data karena compiler melakukan
    pengecean tipe data  secara otomatis 
  C. meningkatkan keterbacaan kode karena tidak perlu menulis kode konversi secara 
     eksplisit
  E.meningkatkan keamanan program compiler akan melakukan pengecekan tipe data secara otomatis
  F.meningkatkan fleksibiliatas program  karena kita dapat menggunakan tipe data yang lebih beasr
    tanpa harus melakukan konversi secara manual
*/

class program
{

            static void  Main ()
    {
byte nilaiByte = 100;
        short nilaiShort = nilaiByte;
        int nilaiInt = nilaiShort;
        long nilaiLong = nilaiInt;
        float nilaiFloat = nilaiLong;
        double nilaiDouble = nilaiFloat;
        decimal nilaiDecimal = (decimal)nilaiDouble;

        Console.WriteLine("Byte    : " + nilaiByte + " " + nilaiByte.GetType());
        Console.WriteLine("Short   : " + nilaiShort + " " + nilaiShort.GetType());
        Console.WriteLine("Int     : " + nilaiInt + " " + nilaiInt.GetType());
        Console.WriteLine("Long    : " + nilaiLong + " " + nilaiLong.GetType());
        Console.WriteLine("Float   : " + nilaiFloat + " " + nilaiFloat.GetType());
        Console.WriteLine("Double  : " + nilaiDouble + " " + nilaiDouble.GetType());
        Console.WriteLine("Decimal : " + nilaiDecimal + " " + nilaiDecimal.GetType());
    








    }



}
