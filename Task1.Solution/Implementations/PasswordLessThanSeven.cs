using System;

namespace Task1
{
    public class PasswordLessThanSeven : ICheckPassword
    {
        public Tuple<bool, string> CheckPassword(string password)
        {
            if (password.Length <= 7)
                return Tuple.Create(false, $"{password} length too short");
            return Tuple.Create(true, password);
        }
    }
}