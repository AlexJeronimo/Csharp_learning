using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace D_OOP
{
    internal class Student
    {

        

        public Student(string lastName, DateTime birthday)
        {
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birthday): this(lastName, birthday)
        {
            this.firstName = firstName;
            this.middleName = middleName;
        }

        public Student(Student student) //to copy Clas object to another object
        {
            firstName = student.firstName;
            middleName = student.middleName;
            lastName = student.lastName;
            birthday = student.birthday;
        }

        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthday;

       public void Print()
        {
            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Middle Name: {middleName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Birthday: {birthday}");
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        

    }



    
}
