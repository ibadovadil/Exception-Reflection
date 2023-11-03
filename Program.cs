using Exceptionn.Exceptions;
using Exceptionn.Models;
using System.Reflection;

namespace Exceptionn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user1 = new User();
            //bool a = true; 

            //do
            //{
            //    Console.WriteLine("Enter Name");
            //    string name = Console.ReadLine();

            //    try
            //    {
            //        user1.Name = name;
            //        a = false; 
            //    }
            //    catch (InvalidNameException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //while (a); 
            //a = true; 

            //do
            //{
            //    Console.WriteLine("Enter age");

            //    if (int.TryParse(Console.ReadLine(), out int age))
            //    {
            //        try
            //        {
            //            user1.Age = age;
            //            a = false;
            //        }
            //        catch (InvalidAgeException ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid age input. Please enter a valid number.");
            //    }
            //}
            //while (a);

            //a = true;

            //do
            //{
            //    Console.WriteLine("Enter phonenumber");
            //    string phonenumber = Console.ReadLine();

            //    try
            //    {
            //        user1.PhoneNumber = phonenumber;
            //        a = false;
            //    }
            //    catch (InvalidNumberException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //while (a);

            //a = true;

            //do
            //{
            //    Console.WriteLine("Enter password");
            //    string password = Console.ReadLine();

            //    try
            //    {
            //        user1.Password = password;
            //        a = false;
            //    }
            //    catch (InvalidPasswordException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //while (a);
            //Console.WriteLine($"Name: {user1.Name}, Age: {user1.Age} , Number: {user1.PhoneNumber}, Password: {user1.Password}");




            //Task 2 (Reflection)


            var field = typeof(User).GetField("_age", BindingFlags.Static | BindingFlags.NonPublic);
            Console.WriteLine(field.GetValue("_age"));
            field.SetValue("_age", (byte)1);
            Console.WriteLine(field.GetValue("_age"));
            var method = typeof(User).GetMethod("ChangeAge", BindingFlags.Static | BindingFlags.NonPublic);
            method.Invoke(obj: null, parameters: new object[] { (byte)3 });
            Console.WriteLine(field.GetValue("_age"));

        }
    }
}
