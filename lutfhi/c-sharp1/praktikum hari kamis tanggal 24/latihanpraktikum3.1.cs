using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kategori suhu");
        
        // 1. Tambahkan baris untuk mengambil input suhu dari pengguna
        Console.Write("Masukan nilai suhu ruangan kamu: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        // 2. Samakan penulisan nama variabel (menggunakan 'kategori' huruf kecil)
        string kategori = "";

        if (suhu < 20)
        {
            kategori = "Dingin nya kayak dieng";
        }
        else if (suhu >= 20 && suhu <= 25)
        {
            kategori = "Sejuk kayak sidoarjo";
        }
        else if (suhu >= 26 && suhu <= 30)
        {
            kategori = "Normal nya kayak di waru";
        }
        else 
        {
            kategori = "Panas akayak perempatan gedangan";
        } 

        Console.WriteLine("\n=== HASIL SUHU KALI INI ===");
        Console.WriteLine($"Suhu terdeteksi : {suhu}");
        Console.WriteLine($"kategori        : {kategori}");
    }
}