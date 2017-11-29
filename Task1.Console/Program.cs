namespace Task1.Console
{
    class Program
    {
        static void Main()
        {
            var passwordChecker = new PasswordCheckerService(new SqlRepository());
            System.Console.WriteLine(passwordChecker.VerifyPassword("12485aw", new PasswordEmpty(), new PasswordLessThanSeven()));
            
            System.Console.ReadKey();

        }
    }
}
