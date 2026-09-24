using System;
class Program
{
    static void Main()
    {
        string  usernameBenar = "admin";
        string  passwordBenar = "12345";
        Console.Write("Username:");
        string username = Console.ReadLine();
        Console.Write("password:");
        string password = Console.ReadLine();
        if(username ==usernameBenar && password==passwordBenar)
        {
            Console.WriteLine("Login berhasil");
        }
        else
        {
            Console.WriteLine("Username atau password salah");
        }
    }
}