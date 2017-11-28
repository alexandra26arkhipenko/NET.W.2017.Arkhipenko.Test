using System;
using System.Linq;

namespace Task1
{
    public class PasswordIsNumbers : ICheckPassword
    {
        public Tuple<bool, string> CheckPassword(string password)
        {
            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");
            return Tuple.Create(true, password);
        }
    }
}