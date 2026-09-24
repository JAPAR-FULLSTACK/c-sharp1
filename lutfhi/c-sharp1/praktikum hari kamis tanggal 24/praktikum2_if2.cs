using System;
class Program
{
    static void Main()
    {
        Console.Write("Masukan nilai anda:");
        int nilai = Convert.ToInt32(Console.ReadLine());
        if(nilai >= 75)
        {
            Console.WriteLine("Status : LULUS");
        }
        else
        {
            Console.WriteLine("Status: TIDAK LULUS");
        }
    }
}