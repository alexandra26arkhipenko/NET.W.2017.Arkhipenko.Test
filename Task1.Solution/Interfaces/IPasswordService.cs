using System;

namespace Task1
{   
    
    public interface IPasswordService
    {
        Tuple<bool, string> VerifyPassword(string password, params ICheckPassword[] checkers);
    }
    
}