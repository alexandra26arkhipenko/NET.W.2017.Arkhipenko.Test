using System;
using Moq;
using NUnit.Framework;

namespace Task1.Solution.Tests
{
    [TestFixture]
    public class Task1Test
    {
        [TestCase("", ExpectedResult = false)]
        [TestCase("1fghj522541", ExpectedResult = true)]
        public bool CheckingPassword_IsEmpty(string password)
        {
            var passwordChecker = new PasswordCheckerService(new SqlRepository());
            return passwordChecker.VerifyPassword(password, new PasswordEmpty()).Item1;
        }

        [TestCase("qwertyuiopasdfghjk5213542352135", ExpectedResult = false)]
        [TestCase("1fghj522541", ExpectedResult = true)]
        public bool CheckingPassword_TooLong(string password)
        {
            var passwordChecker = new PasswordCheckerService(new SqlRepository());
            return passwordChecker.VerifyPassword(password, new PasswornGreaterThanFifteen()).Item1;
        }

        [TestCase("wertyuiohj", ExpectedResult = false)]
        [TestCase("1fghj522541", ExpectedResult = true)]
        public bool CheckingPassword_IsLetters(string password)
        {
            var passwordChecker = new PasswordCheckerService(new SqlRepository());
            return passwordChecker.VerifyPassword(password, new PasswordIsLetters()).Item1;
        }

        [TestCase("5526235325", ExpectedResult = false)]
        [TestCase("1fghj522541", ExpectedResult = true)]
        public bool CheckingPassword_IsNumbers(string password)
        {
            var passwordChecker = new PasswordCheckerService(new SqlRepository());
            return passwordChecker.VerifyPassword(password, new PasswordIsNumbers()).Item1;
        }

        [TestCase("123", ExpectedResult = false)]
        [TestCase("1fghj522541", ExpectedResult = true)]
        public bool CheckingPassword_LessThanSeven(string password)
        {
            var passwordChecker = new PasswordCheckerService(new SqlRepository());
            return passwordChecker.VerifyPassword(password, new PasswordLessThanSeven()).Item1;
        }

        [TestCase("aaaa234a")]
        [TestCase("5aaa23aaa")]
        [TestCase("aa234234aa")]
        public void PasswordCheckerServiceCallRepository_CreateMethod(string password)
        {
            var repositoryMock = new Mock<IRepository>();
            var passwordChecker = new PasswordCheckerService(repositoryMock.Object);

            passwordChecker.VerifyPassword(password, new PasswordEmpty());

            repositoryMock.Verify(repository => repository.Create(It.Is<string>(s => string.Equals(s, password, StringComparison.Ordinal))), Times.Once);
        }


    }
}