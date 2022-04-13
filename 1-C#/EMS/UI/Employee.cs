﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    enum Authority
    {
        Hire, Fire, Delegate
    }
    // parent/super/Base
    public class Employee
    {
        // members -> variables, constants, methods, events, constructors etc......
        //variable => State of the object
        protected string firstName = "Joe", lastName = "Dow", id = "101";
        public const string planet = "Earth";
        protected int age;

        //Methods=>Behaviour
        public void DoTask(string firstName, string lastName, string id, float hours)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            Console.WriteLine($"{firstName} {lastName} writes program in C# for {hours} hours over weekdays");
        }
    }
    //child/sub/derived class 
    class Manager : Employee
    {
       public Authority authority;
       public string GetDetails(string firstName, string lastName, string id, int age)
        {
            base.firstName = firstName;
            base.lastName = lastName;
            base.age = age;
            base.id = id;
            authority = Authority.Hire;
           return $"Name - {firstName} {lastName}\nAge - {age}\nEmployee id - {id}";
        }
    }
    
}
