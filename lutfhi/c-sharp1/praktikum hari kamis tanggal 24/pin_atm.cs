using System;

class Program
{
    static void Main()
    {
    
        const string PIN_BENAR = "123456";
        double saldo = 5000000; 

        Console.WriteLine("=== SIMULASI TRANSAKSI ATM ===");
        
        
        Console.Write("Masukkan PIN Anda: ");
        string pinInput = Console.ReadLine();

        if (pinInput == PIN_BENAR)
        {
            Console.WriteLine("\nPIN Benar!");
            Console.WriteLine($"Saldo Anda Saat Ini: Rp {saldo:N0}");
            

            Console.Write("Masukkan jumlah penarikan (Rp): ");
            double jumlahTarik = Convert.ToDouble(Console.ReadLine());

            
            if (jumlahTarik <= saldo)
            {
                saldo -= jumlahTarik; 
                
                Console.WriteLine("\n=== TRANSAKSI BERHASIL ===");
                Console.WriteLine($"Uang yang ditarik : Rp {jumlahTarik:N0}");
                Console.WriteLine($"Sisa Saldo Anda   : Rp {saldo:N0}");
            }
            else
            {
                Console.WriteLine("\n=== TRANSAKSI DITOLAK ===");
                Console.WriteLine("Alasan: Saldo Anda tidak mencukupi untuk melakukan penarikan ini.");
            }
        }
        else
        {
            Console.WriteLine("\n=== TRANSAKSI GAGAL ===");
            Console.WriteLine("Alasan: PIN yang Anda masukkan salah. Transaksi tidak dapat dilanjutkan.");
        }
    }
}