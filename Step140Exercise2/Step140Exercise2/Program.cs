using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step140Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//Instantiating the class.


            //Employee employee = new Employee();

            //employee.Firstname = new List<string>();

            //Employee employee = new List();



            //List<Employee> x = new List<Employee>();
            //x.Add(new Employee("Barnaby", "Thunder", 1));
            //x.Add(new Employee("Joe", "Caulfield", 2));
            //x.Add(new Employee("Tanner", "Shetland", 3));
            //x.Add(new Employee("Garth", "Wayne", 4));
            //x.Add(new Employee("Tiffany", "Haufen", 5));
            //x.Add(new Employee("Johnathan", "Pulansky", 6));
            //x.Add(new Employee("Joe", "Borgia", 7));
            //x.Add(new Employee("Chaz", "Antietam", 8));
            //x.Add(new Employee("Shinusuke", "Omane", 9));
            //x.Add(new Employee("Vivian", "Melrose", 10));


            //List<Employee> y = new List<Employee>(); 

            //foreach (Employee e in x)
            //{
            //    if (e.Firstname == "Joe") 
            //    {
            //        Console.WriteLine(e.Firstname);
            //        Console.WriteLine(e.Lastname); 
            //        Console.ReadLine();
            //    }

            //}




            List<Employee> xlist = new List<Employee>();
            {
                xlist.Add(new Employee("Barnaby", "Thunder", 1));
                xlist.Add(new Employee("Joe", "Caulfield", 2));
                xlist.Add(new Employee("Tanner", "Shetland", 3));
                xlist.Add(new Employee("Garth", "Wayne", 4));
                xlist.Add(new Employee("Tiffany", "Haufen", 5));
                xlist.Add(new Employee("Johnathan", "Pulansky", 6));
                xlist.Add(new Employee("Joe", "Borgia", 7));
                xlist.Add(new Employee("Chaz", "Antietam", 8));
                xlist.Add(new Employee("Shinusuke", "Omane", 9));
                xlist.Add(new Employee("Vivian", "Melrose", 10));
            };
            List<Employee> b = xlist.Where(x => x.Firstname == "Joe").ToList();
            List<Employee> c = xlist.Where(x => x.Id > 5).ToList();
            foreach (Employee e in c)
            {
                Console.WriteLine(e.Firstname + ", " + e.Lastname);
                Console.WriteLine(e.Id);
            }

            Console.ReadLine();
        }

        public class Employee
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public int Id { get; set; }

            public Employee()
            {
                Firstname = "";
                Lastname = "";
                Id = 0;
            }
            public Employee(string fname, string lname, int id)
            {
                Firstname = fname;
                Lastname = lname;
                Id = id;
            }
            public override string ToString()
            {
                return ($"Hello my name is {Firstname} {Lastname} and my ID is {Id}");
            }
        }
    }
}
