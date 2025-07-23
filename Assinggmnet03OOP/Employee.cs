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
        //private int id;
        //public int Id
        //{
        //    get => id;
        //    set => id = (value > 0) ? value : 1;
        //}

        //private string name;
        //public string Name
        //{
        //    get => name;
        //    set => name = string.IsNullOrWhiteSpace(value) ? "Unknown" : value;
        //}

        //private double salary;
        //public double Salary
        //{
        //    get => salary;
        //    set => salary = (value >= 0) ? value : 0;
        //}

        //public SecurityLevel SecurityLevel { get; set; }
        //public DateTime HireDate { get; set; }

        //public Gender Gender { get; set; }

        #endregion

        #region constractor
        //public Employee(int _Id, string _Name, SecurityLevel _securityLevel, double _salary, DateTime _hireDate, Gender _gender)
        //{
        //    Id = _Id;
        //    name = _Name;
        //    SecurityLevel = _securityLevel;
        //    Salary = _salary;
        //    HireDate = _hireDate;
        //    Gender = _gender;
        //}
        #endregion

        #region Attrubites 
        private int id;
        private string name;
        private double salary;
        private SecurityLevel securityLevel;
        private HiringDate hireDate;
        private Gender gender;
        #endregion
        #region Using Setter Getter 
        public int GetId() => id;
        public void SetId(int value) => id = (value > 0) ? value : 1;

        public string GetName() => name;
        public void SetName(string value) => name = string.IsNullOrWhiteSpace(value) ? "Unknown" : value;

        public double GetSalary() => salary;
        public void SetSalary(double value) => salary = (value >= 0) ? value : 0;

        public SecurityLevel GetSecurityLevel() => securityLevel;
        public void SetSecurityLevel(SecurityLevel value) => securityLevel = value;

        public HiringDate GetHireDate() => hireDate;
        public void SetHireDate(HiringDate value) => hireDate = value;

        public Gender GetGender() => gender;
        public void SetGender(Gender value) => gender = value;

        #endregion

        #region
        public Employee(int id, string? name, SecurityLevel level, double salary, HiringDate hireDate, Gender gender)
        {
            SetId(id);
            SetName(name);
            SetSecurityLevel(level);
            SetSalary(salary);
            SetHireDate(hireDate);
            SetGender(gender);
        }
        #endregion




        #region Method
        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Gender: {gender}, Security Level: {securityLevel}, " +
                   $"Salary: {string.Format("{0:C}", salary)}, Hire Date: {hireDate.ToShortDateString()}";
        }
        #endregion
    }
}
