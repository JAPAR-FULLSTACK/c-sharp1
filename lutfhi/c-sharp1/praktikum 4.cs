using System;
class Program
{
    static void Main ()
    {
        Console.Write("apakah siswa? (true/false)");
        bool siswa = Convert. ToBoolean(Console.ReadLine());
        Console.Write("apakah guru(true/false)");
        bool guru = Convert.ToBoolean(Console.ReadLine());
        Console.Write("Memiliki kartu akses ? (true/false)");
        bool kartuakses =Convert.ToBoolean(Console.ReadLine());
        if((siswa || guru) && kartuakses)
        {
            Console.WriteLine("akses  labotarium DITERIMA  ");
        }
else
        {
            Console.WriteLine("Akses laboartium  DITOLAK");
            
        }
    }
}