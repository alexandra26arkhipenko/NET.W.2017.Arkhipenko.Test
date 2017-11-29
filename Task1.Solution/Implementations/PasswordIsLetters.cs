using System;
using System.Linq;

namespace Task1
{
    public class PasswordIsLetters : ICheckPassword
    {
        public Tuple<bool, string> CheckPassword(string password)
        {
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
            return Tuple.Create(true, password);
        }
    }
}