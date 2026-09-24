using System;
class Program
{
    static void Main()
    {
        Console.Write("Masukan sebuah angka : ");
        int angka = Convert. ToInt32(Console.ReadLine());
        if ( angka % 2 == 0)
        {
            Console.WriteLine("bilangan Genap");
        }
        else
        {
            Console.WriteLine("Bilangan ganjil");
        }
    }
}