using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProyect.Inheritance
{
    public class Student : NttDataBase
    {
        public string name;
        public string surname;
        public DateTime birthday;
        public Address address;

        public Student(string name, string surname, DateTime birthday, Address address) 
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.address = address;
        }

       
    }
}
