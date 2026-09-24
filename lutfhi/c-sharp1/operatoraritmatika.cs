using System;
namespace BelajarOperatorAritmatika
{
    class Program
    {
        static void Main (string[]args)
        {
            int angka1 =17;
            int angka2 =5;
            //1. penjumlahan (+)
            int hasilTambah = angka1 + angka2;
            Console.WriteLine($"{angka1}+ {angka2}= {hasilTambah}");
            //2.pengurangan (-)
            int hasilkurang = angka1 -angka2;
            Console.WriteLine($"{angka1} - {angka2} ={hasilkurang}");
            //3.perkalian (*)
            int hasilkali =angka1 * angka2;
            Console.WriteLine($"{angka1} * {angka2} ={hasilkali}");
            //4. pembagian bulat (/)
            //karena kedua variable bertipe  int, hasilnya dibulatkan kebawah
            int hasilbagibulat = angka1/angka2;
            Console.WriteLine($"{angka1}/ {angka2} (Interger Division ) = {hasilbagibulat}");
            //5. pembagian  pecahan  (tye casting)
            // diubah ke double  agar  menghasilkan  angka  di belakang  koma
            double hasilbagideimal = (double)angka1 /angka2;
            Console.WriteLine($"{angka1}/ {angka2}(floating Point)= {hasilbagideimal}");
            //6. modul/sisabagi
            int siabagi= angka1 % angka2 ;
            Console.WriteLine($"{angka1}%{angka2} (sisabagi)= {siabagi}");
            //7. increment (++) dan decrement (--)
            int nilai = 10;
            nilai++;//menambah nilai sebesar 1 (nilai sekarang 11)
            Console.WriteLine($"nilai setelah incriment (++):{nilai}");
            nilai--; // mengurangi  nilai sebesar  1(nilai sekarang 10)
            Console.WriteLine($"nilai setelah decrement (--): {nilai}");
            Console.ReadLine();


        }
    }
}