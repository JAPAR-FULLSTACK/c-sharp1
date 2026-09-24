using System;
    class Program
{
    static void Main()
    {
       Console.Write("Masukan nilai : "); 
       int nilai =Convert.ToInt32(Console.ReadLine());
       if (nilai >= 75)
       {
            Console.WriteLine("Selamat, Anda telah mencapai nilai ketuntasan ");
        }
       Console.WriteLine("Program selesai.");
        
       
    }
}
