using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SELEKSI KELAYAKAN PKL ===");

        
        Console.Write("Masukkan Nilai Produktif : ");
        double nilaiProduktif = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan Kehadiran (%)   : ");
        double kehadiran = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan Nilai Sikap     : ");
        double nilaiSikap = Convert.ToDouble(Console.ReadLine());

        string status = "";
        string alasan = "";


        if (nilaiProduktif >= 80)
        {
            if (kehadiran >= 90)
            {
                if (nilaiSikap >= 80)
                {
                    status = "LAYAK PKL";
                    alasan = "Seluruh persyaratan terpenuhi.";
                }
                else
                {
                    status = "TIDAK LAYAK PKL";
                    alasan = "Nilai sikap kurang dari 80.";
                }
            }
            else
            {
                status = "TIDAK LAYAK PKL";
                alasan = "Persentase kehadiran kurang dari 90%.";
            }
        }
        else
        {
            status = "TIDAK LAYAK PKL";
            alasan = "Nilai produktif kurang dari 80.";
        }

        // Output hasil
        Console.WriteLine("\n=== HASIL KELAYAKAN PKL ===");
        Console.WriteLine($"Nilai Produktif : {nilaiProduktif}");
        Console.WriteLine($"Kehadiran       : {kehadiran}%");
        Console.WriteLine($"Nilai Sikap     : {nilaiSikap}");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"Status Akhir    : {status}");
        Console.WriteLine($"Alasan          : {alasan}");
    }
}