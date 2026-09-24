using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEM DISKON KANTIN ANTREK NYELL ===");
        
    
        Console.Write("Masukan total belanja (Rp): ");
        double totalBelanja = Convert.ToDouble(Console.ReadLine());

        double persentaseDiskon = 0;

        
        if (totalBelanja >= 1000000)
        {
            persentaseDiskon = 0.20; 
        }
        else if (totalBelanja >= 500000)
        {
            persentaseDiskon = 0.10; 
        }
        else if (totalBelanja >= 250000)
        {
            persentaseDiskon = 0.05; 
        }
        else
        {
            persentaseDiskon = 0; 
        }

        
        double nominalPotongan = totalBelanja * persentaseDiskon;
        double totalBayar = totalBelanja - nominalPotongan;

        
        Console.WriteLine("\n=== DETAIL PEMABYARAN YANG HARUS DIBYARKAN  ===");
        Console.WriteLine($"Total Belanja            : Rp {totalBelanja:N0}");
        Console.WriteLine($"Persentase Diskon        : {persentaseDiskon * 100}%");
        Console.WriteLine($"Nominal Potongan Diskon  : Rp {nominalPotongan:N0}");
        Console.WriteLine($"Total Bayar Setelah Diskon: Rp {totalBayar:N0}");
    }
}