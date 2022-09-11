using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuitorial2
{
    public class StudentRepo
    {

        public string saveStudent(int id, string name, string lastname , int age)
        {
            Student student = new Student();
            
            int _id =  student.Id = id;
            string _name =  student.Name = name;
            string _lastname = student.Name = lastname;
            int _age = student.age = age;


            return _id + " " + _name + " " + _lastname + " "+ _age;
        }
    }
}
