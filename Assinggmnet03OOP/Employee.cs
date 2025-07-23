using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assinggmnet03OOP
{
    internal class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string? name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Gender Gender { get; set; }

        #endregion



        #region constractor
        public Employee(int _Id, string _Name, SecurityLevel _securityLevel, double _salary, DateTime _hireDate, Gender _gender)
        {
            Id = _Id;
            name = _Name;
            SecurityLevel = _securityLevel;
            Salary = _salary;
            HireDate = _hireDate;
            Gender = _gender;
        }
        #endregion
        #region Method
        public override string ToString()
        {
            return $"ID: {Id}, Name: {name}, Gender: {Gender}, Security Level: {SecurityLevel}, " +
                   $"Salary: {string.Format("{0:C}", Salary)}, Hire Date: {HireDate.ToShortDateString()}";
        }
        #endregion
    }
}
