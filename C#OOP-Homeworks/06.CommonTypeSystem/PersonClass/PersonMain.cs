﻿
//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality.

namespace PersonClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PersonMain
    {
        static void Main()
        {
            Person firstPerson = new Person("Ivan Stefanov", 25);
            Person secondPerson = new Person("Peter Stoqnov");

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
