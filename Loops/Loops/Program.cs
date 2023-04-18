namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new String('-',30));
            string userName;
            string password;
            do
            { 
                Console.WriteLine("Zehmet olmasa istifadeci adinizi girin:");
                userName = Console.ReadLine().Trim().ToLower();
                Console.WriteLine("Zehmet olmasa istifadeci parolunuzu girin:");
                password = Console.ReadLine().Trim().ToLower();
            } while (userName != "admin" && password!="123");
            Console.WriteLine(new String('-', 30));
            Console.WriteLine("Xosh Geldiniz");
        }
    }
}