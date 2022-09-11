using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuitorial2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StudentRepo studentRepo = new StudentRepo();

            while (true) {

            Console.WriteLine("Enter Student Details");
             Console.WriteLine();


                string id;
            Console.Write("Enter Id No.: ");
            id = Console.ReadLine();

            string name;
            Console.Write("Enter name: ");
            name = Console.ReadLine();



            string lastname;
            Console.Write("Enter lastname: ");
            lastname = Console.ReadLine();

            string age;
            Console.Write("Enter age: ");
            age = Console.ReadLine();

            Console.WriteLine(studentRepo.saveStudent(int.Parse(id), name, lastname, int.Parse(age)));
            Console.ReadLine();

            }
        }
    }
}
