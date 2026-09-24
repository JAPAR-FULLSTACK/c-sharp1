using System;
class program
{
    static void Main (string [] args)
    {
        //deklarasi variabl
        string nama;
        string kelas;
        int usia;
        double nilai;
        char jeniskelamin;
        bool aktif;

        //Proses input
        //console.Readline () digunakan untuk membaca input dari pengguna
        Console.WriteLine("=============================");
        Console.WriteLine("Input data siswa");
        Console.Write("Masukan nama            :");
        nama = Console.ReadLine()?? " ";
        Console.Write("Masukan kelas           :");
        kelas = Console.ReadLine ()?? " ";
        Console.Write("Masukan usia            :");
        usia = Convert.ToInt32 (Console.ReadLine ());
        Console.WriteLine("Masukan nilai anda :");
        nilai = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Jenis kelamin anda (L/P) :");
        jeniskelamin = Convert.ToChar (Console.ReadLine()?? "L");
        Console.WriteLine("Status anda aktif (True/False) :");
        aktif = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("=============================");

        //Menampilkan hasil input


        Console.WriteLine("\n===== DATA SISWA====");
        Console.WriteLine($"Nama         :{nama}");
        Console.WriteLine($"Kelas        :{kelas}");
        Console.WriteLine($"Usia         :{usia}");
        Console.WriteLine($"Nilai        :{nilai}");
        Console.WriteLine($"Jenis kelamin:{jeniskelamin}");
        Console.WriteLine($"Status aktif  :{aktif}");
        Console.WriteLine("=======================");
        Console.WriteLine("tekan enter untuk keluar dari sini.......");
        Console.ReadLine();



    }
}