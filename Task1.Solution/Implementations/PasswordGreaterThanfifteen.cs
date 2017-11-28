using System;

namespace Task1
{
    public class PasswornGreaterThanFifteen : ICheckPassword
    {
        public Tuple<bool, string> CheckPassword(string password)
        {
            if (password.Length >= 15)
                return Tuple.Create(false, $"{password} length too long");
            return Tuple.Create(true, password);
        }
    }
}