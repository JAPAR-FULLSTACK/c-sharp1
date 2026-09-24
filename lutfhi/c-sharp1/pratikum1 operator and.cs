using System;
class Program
{
    static void Main ()
    {
        Console.Write(" Masukan nilai");
        int nilai =Convert.ToInt32(Console.ReadLine());
        Console.Write("masukan presentase kehadiran");
        int kehadiran = Convert.ToInt32(Console.ReadLine());
        if(nilai>= 80&& kehadiran >=90)
        {
            Console.WriteLine("Status:Lulus");

        }
        
            
            
              else
                {
                   Console.WriteLine("Status:tidak lulus") ;

                }
            
        
    }
}