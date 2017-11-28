using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IPasswordService passwordChecker = new PasswordCheckerService(new SqlRepository());
            System.Console.WriteLine(passwordChecker.VerifyPassword("12485", new PasswordEmpty(), new PasswordLessThanSeven()));


            System.Console.ReadKey();

        }
    }
}
