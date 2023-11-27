using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
namespace ConsoleApplication3
{
    internal class Program
    {
        static void Foo(params object[] parametres)
        {
            string message = "Type of data {0}, value{1}";//2 из за этого
            foreach (var item in parametres)
            {
                Console.WriteLine(message,item.GetType(),item);//1то есть принимает переменную а потом две подпеременные из парамса
            }
        }

        static void Main(string[] args)
        {
            Foo("test",5,6,2,3);
            object o = 5;
            object a = 55;
        }
    }
}