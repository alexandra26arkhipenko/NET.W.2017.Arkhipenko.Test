using System;
using System.Linq;

namespace Task1
{ 
//{E:\Учеба\EPAM\NET.W.2017.LastName.Test\Task1\PasswordCheckerService.cs
    public class PasswordCheckerService 
    {
        private readonly IRepository _repository;

        public PasswordCheckerService(IRepository repository)
        {
            _repository = repository;
        }

        public Tuple<bool, string> VerifyPassword(string password, params ICheckPassword[] chekers)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            foreach (var checkPassword in chekers)
            {
                var x = checkPassword.CheckPassword(password);
                if (!x.Item1)
                {
                    return x;
                }
            }

            _repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }

    }
}
