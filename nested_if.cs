using System;

namespace PenentuanKelulusan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("    PROGRAM KELULUSAN  SISWA    ");
            Console.WriteLine("===========================================\n");

            // Deklarasi dan Input Data Siswa
            Console.Write("Masukan nama anda          : ");
            string namaSiswa = Console.ReadLine();

            Console.Write("Masukkan Nilai Teori       : ");
            double nilaiTeori = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Nilai Praktik     : ");
            double nilaiPraktik = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Kehadiran (%)     : ");
            double kehadiran = Convert.ToDouble(Console.ReadLine());

            string status = "";
            string alasan = "";


            if (nilaiTeori >= 75)
            {
                if (nilaiPraktik >= 75)
                {
                    if (kehadiran >= 80)
                    {
                        status = "Lulus";
                        alasan = "Memenuhi seluruh kriteria kelulusan.";
                    }
                    else
                    {
                        status = "Tidak Lulus";
                        alasan = "Kehadiran kurang dari 80";
                    }
                }
                else
                {
                    status = "Tidak Lulus";
                    alasan = "Nilai praktik kurang dari 75";
                }
            }
            else
            {
                status = "Tidak Lulus";
                alasan = "Nilai teori kurang dari 75";
            }

            // Output Hasil Akhir
            Console.WriteLine("\n===========================================");
            Console.WriteLine("               HASIL PENILAIAN   ");
            Console.WriteLine("===========================================");
            Console.WriteLine($"Nama Siswa       : {namaSiswa}");
            Console.WriteLine($"Status Kelulusan : {status}");
            
            if (status == "Tidak Lulus")
            {
                Console.WriteLine($"Alasan           : {alasan}");
            }
            else
            {
                Console.WriteLine($"Keterangan       : {alasan}");
            }
            Console.WriteLine("===========================================");
        }
    }
}