using System;

namespace Task1
{
    public interface IPasswordCheckerService
    {
        Tuple<bool, string> VerifyPassword(string password);
    }
}