using System;

namespace Task1
{
    public class PasswordEmpty : ICheckPassword
    {
        public Tuple<bool, string> CheckPassword(string password)
        {
            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");
            return Tuple.Create(true,password); ;
        }
    }
}