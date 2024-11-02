using System;

class Program
{
    static void Main()
    {
        string correctUsername = "admin";
        string correctPassword = "Admin_32453@";

        Console.Write("Kullanıcı adı: ");
        string username = Console.ReadLine();

        Console.Write("Şifre: ");
        string password = Console.ReadLine();

        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("Giriş başarılı!");
        }
        else
        {
            Console.WriteLine("Giriş başarısız!");
        }
    }
}
