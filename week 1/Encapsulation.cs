using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation
{
    internal class person
    {
        private string fName;
        private string lName;
        private int salary;
        private int Age;
        private double rel;





        public void setfName(string fname)
        {
            this.fName = fname;

        }
        public string getfName(string fname)
        {
            return fName;
        }
        public void setlName(string lname)
        {
            this.lName = lname;
        }
        public string getlName(string lname)
        {
            return lName;
        }

        public void setsalary(int Salary)
        {
            this.salary = Salary;
        }
        public int getsalary(string Salary)
        {
            return salary;
        }

        public void setAge(int age)
        {
            this.Age = age;
        }
        public int getAge(int age)
        {
            return Age;
        }

        public void serel(double Rel)
        {
            this.rel = Rel;
        }
        public double getrel(double Rel)
        {
            return rel;
        }
        public string printInfo()
        {
            return $"first name {fName}, last name {lName},salary {salary},your Age {Age},rel{rel}";
        }
    }
  
}

