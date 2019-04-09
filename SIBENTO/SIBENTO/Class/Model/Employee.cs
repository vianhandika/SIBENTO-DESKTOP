using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIBENTO.Class.Model
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public string salary { get; set; }
        public string role { get; set; }
        public string branch { get; set; }

        public Employee(int id, string name, string phone_number, string address, string salary, string role, string branch)
        {
            this.id = id;
            this.name = name;
            this.phone_number = phone_number;
            this.address = address;
            this.salary = salary;
            this.role = role;
            this.branch = branch;
        }

        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            return employee != null &&
                   id == employee.id;
        }

        public void Update(Employee employee)
        {
            this.id = employee.id;
            this.name = employee.name;
            this.phone_number = employee.phone_number;
            this.address = employee.address;
            this.salary = employee.salary;
            this.role = employee.role;
            this.branch = employee.branch;
        }
    }
}
