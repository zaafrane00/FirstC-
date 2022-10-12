using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Employee
    {

        private int id;
        private string name;
        private string lastName;
        private int age;

       


        public Employee(int id, string name, string lastName, int age)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        public Employee() { }

        public int getId() { return id; }
        public string getName() { return name; }
        public string getLastName() { return lastName; }
        public int getAge() { return age; }
        public void setAge(int age) { this.age = age; }

        public void setId(int id) { this.id = id; }

        public void setName(string name) { this.name = name; }

        public void setLastName(string lastName) { this.lastName = lastName; }

        public override string ToString()
        {
            return id + " " + name + " " + lastName+" " +age;
        }

        public abstract double GetSalaire();

        


    }
}
