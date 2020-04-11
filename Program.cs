using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jono", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Joni", 50, 190104, "logical information", "Dosen@teacher.amikom.ac.id");
            teacher.GetNameAndAge();

            Student student = new Student("Havid Pradipta Husada", 19, 2721, "havid.husada@student.amikom.ac.id");
            student.GetNameAndAge();
        }
    }
}