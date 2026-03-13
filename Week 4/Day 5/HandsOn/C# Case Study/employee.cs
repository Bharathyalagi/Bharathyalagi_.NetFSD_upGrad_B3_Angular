using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRsystem
{
    class Employee
    {
        private string _fullname;
        private int _age;
        private decimal _salary;
        private readonly string _employeeId;



        public string Fullname
        {
            get { return _fullname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                _fullname = value.Trim();
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 18 || value > 80)
                {
                    throw new ArgumentException("Age must be between 18 and 80");
                }
                _age = value;

            }
        }
        public decimal Salary
        {
            get { return _salary; }
            private set
            {
                if (value < 1000)
                {
                    throw new ArgumentException("salary cannot be less than 1000");
                }
                _salary = value;
            }
        }
        public string EmployeeId
        {
            get { return _employeeId; }
        }

        public Employee(string name, decimal startSalary, int empAge)
        {

            Fullname = name;
            Age = empAge;
            Salary = startSalary;
        }
        public void GiveRaise(decimal percentage)
        {
            if (percentage <= 0 || percentage > 30)
            {
                throw new ArgumentException("Raise percentage must be between 0 and 30");

            }
            decimal increase = _salary * (percentage / 100);
            Salary = _salary + increase;
            Console.WriteLine("Raise successfully applied");
        }
        public bool DeductPenalty(decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            decimal newSalary = _salary - amount;
            if (newSalary < 1000)
            {
                return false;
            }
            Salary = newSalary;
            return true;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Emploee ID: {EmployeeId}");
            Console.WriteLine($"Name : {Fullname}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Salary: {Salary}");


        }
    }
}


       