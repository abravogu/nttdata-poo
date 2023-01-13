using CalculatorProyect.Loops;
using CalculatorProyect.PlanPensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProyect.Inheritance
{
    public class BusquedaEstudiantes
    {

        public static List<Student> BuscarEstudiantes(List<Student> students)
        {

            IEnumerable<Student> StudentQuery =
   from student in students
   where (CalcularEdad(student) > 30)
   && (student.name.ToCharArray()[0] == 'S')
   &&(student.address.city.Equals("Madrid"))
   select student;
           
            return StudentQuery.ToList();
        }

        public static int CalcularEdad(Student student)
        {
            DateTime date_1 = new DateTime(student.birthday.Year, student.birthday.Month, student.birthday.Day);
            DateTime date_2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
           return (date_2 - date_1).Days;
           
        }
    }
}
