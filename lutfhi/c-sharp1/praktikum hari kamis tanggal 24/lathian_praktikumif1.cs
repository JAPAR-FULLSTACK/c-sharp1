using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Tolong masukan usia anda untuk pembuatan sim");
        int usia =Convert.ToInt32(Console.ReadLine());
        if(usia >= 18)
        {
            Console.WriteLine("Umur anda telah meamsuki persyaratan untuk ujian sim ini");

        }
        if(usia <= 18)
        {
             Console.WriteLine("Silahkan kemabli ke tahun depan ketika usia/umur anda telah memenuhi persyaratan");

        }
Console.WriteLine("Program telah di shutdown");

       

    }
}