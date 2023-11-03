using Exceptionn.Exceptions;
using System.Text.RegularExpressions;

namespace Exceptionn.Models
{
    internal class User
    {
        //private string _name;
        //public string Name
        //{
        //    get => _name;
        //    set
        //    {
        //        if (value.Length > 2 && value.Length < 30)
        //        {
        //            _name = value;
        //        }
        //        else
        //        {
        //            throw new InvalidNameException("Name 2 den kicik 30 dan boyuk ola bilmez");
        //        }
        //    }
        //}
        //private int _age;
        //public int Age
        //{
        //    get => _age;
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            _age = value;
        //        }
        //        else
        //        {
        //            throw new InvalidAgeException("Age 0 dan boyuk olmalidir");
        //        }
        //    }
        //}
        //private string _phonemumber;
        //public string PhoneNumber
        //{
        //    get => _phonemumber; set
        //    {
        //        Regex phoneFormat = new Regex(@"^\+994-(050)|(051)|(070)|(055)-[0-9]{3}-[0-9]{2}-[0-9]{2}$");
        //        if (!phoneFormat.IsMatch(value))
        //        {
        //            throw new InvalidNumberException("nomre bele deyl");
        //        }
        //        _phonemumber = value;
        //    }
        //}
        //private string _password;
        //public string Password
        //{
        //    get => _password; set
        //    {
        //        Regex passwordFormat = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z]).{8,}$");
        //        if (!passwordFormat.IsMatch(value))
        //        {
        //            throw new InvalidPasswordException("olmaz");
        //        }
        //        _password = value;
        //    }
        //}

        //Task 2 (Reflection)

        private int _id;
        private string _name;
        private static int _age;

        static void ChangeAge(int age)
        {
            _age = age;
        }
    }
}
