using System;
class Program
{
    static void Main ()
    {
        Console.Write("Nilai teori ");
        int teori = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nilai praktek");
        int praktek= Convert.ToInt32(Console.ReadLine());
        if(teori <80 || praktek <80)
        {
            Console.WriteLine("Murid mengikuti REMEDIAL.");
        }

        
       else
            {
             Console.WriteLine("Murid tidak perlu REMEDIAL");
            }        
    }
}