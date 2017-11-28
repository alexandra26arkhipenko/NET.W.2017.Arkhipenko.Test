using System;

namespace Task1
{
    public interface ICheckPassword
    {
        Tuple<bool, string> CheckPassword(string password);
    }
}