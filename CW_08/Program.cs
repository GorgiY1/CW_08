using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_08
{
    abstract class Shape
    {
        private int _x;

        public double S { get; set; }

        public Shape()
        {

        }
        
        public abstract void M();
        
    }
    abstract class Human
    {
        private int _id;
        protected string lastName;

        //public Humen(string _lastName)
        //{
        //    lastName = _lastName;
        //}

        public abstract void Think();
        
        public virtual void Print()
        {
            Console.WriteLine($"{lastName}");
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{lastName}";
        }
    }

    class Employee : Human
    {
        //public int num;
        private double _salary;
        public Employee(string name, double salary) //: base(name)
        {
            lastName = name;
            _salary = salary;

        }

        public override void Think()
        {
            Console.WriteLine("Employee think");
        }

        //Print();
        public void Show()
        {
            base.Print();
            //Console.WriteLine($"{lastName} {_salary}");
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($" {_salary}");
        }
    }

    sealed class Teacher : Employee
    {
        private string _logbook = "Test";
        public Teacher(string name, double salary):base(name,salary)
        {
            
        }

        public override void Think()
        {
            Console.WriteLine("Teacher think");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{_logbook}");
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{base.ToString()} {_logbook}";
        }
        
    }

    class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary)
        {

        }

        public void Lead() { }

        public override void Think()
        {
            Console.WriteLine("Manager think");
        }

    }

    //class UnEmployee : Human
    //{
    //    public UnEmployee(string name) //: base(name)
    //    {
    //        lastName = name;
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee("Max",4000);
            //employee.Show();
            //employee.Print();

            //Human human = new Employee("Davis", 1582.74);
            //human.Print();


            //Human[] people = { new Employee("Moore", 1445.82), new UnEmployee("Doe") };


            //foreach (Human item in people)
            //{
            //    try
            //    {
            //        ((Employee)human).Show();
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //    Employee empl = item as Employee;

            //1
            //    if (empl!=null)
            //    {
            //        empl.Show();
            //    }
            //2
            //    if (empl is Employee)
            //    {
            //        (empl as Employee).Show();
            //    }
                    //3
            //    if (empl is Employee employee1)
            //    {
            //        employee1.Show();
            //    }
            //}

            //Human human = new Employee("Davis", 1582.74);
            //human.Print();

            //Human[] people = { new Employee("Moore", 1445.82), 
            //                   new UnEmployee("Doe"),
            //                   new Teacher("Talor",6365.56) };

            //foreach (Human item in people)
            //{
            //    item.Print();
            //    Console.WriteLine();
            //}

            //Human human1 = new Human(); //!!! cannotbe
            //Human human1 = Teacher("Miller", 5623.84);

            //Human teacher = new Teacher("Miller", 5623.84);

            //Human[] employees = { teacher, new Manager("Allen", 45632.56) };

            //foreach (Human item in employees)
            //{
            //    item.Think(); // Полиморфизм
            //}

            Human teacher = new Teacher("Miller", 5623.84);
            Console.WriteLine(teacher);

            Console.ReadKey();
        }
    }
}
