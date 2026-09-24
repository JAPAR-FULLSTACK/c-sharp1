using System;
class Program
{
    static void Main()
    {
        Console.Write("masukan nilai nya :");
        int nilai= Convert.ToInt32(Console.ReadLine());
        if (nilai >= 90)
        
            Console.WriteLine("Predikat A");
        
        else if (nilai >= 80)
        
          Console.WriteLine(" Predikat B");

        
        else if (nilai >= 75)
        
            Console.WriteLine("Predikat C");

        
        else if (nilai >= 60)
        
            Console.WriteLine("Predikat D");
        
        else
        
            Console.WriteLine("predikat E");

        

    }
}