using System.Security;

namespace class_oop
{
    internal class Program
    {
        public class Employee

        {
            public const double Tax = 0.03;
            public string FName;
            public string LName;
            public double Wage;
            public double LoggedHours;

        }
        static void Main(String[] args)
        {
            Employee emp = new Employee();
            emp.FName = "Elham";
            emp.LName = "Alhinai";
            emp.Wage = 10;
            emp.LoggedHours = 10;
            double totalSalary = emp.LoggedHours * emp.Wage;
            double TaxRate = emp.LoggedHours * emp.Wage * Employee.Tax;

            double netSalary = totalSalary - TaxRate;
            Console.WriteLine($"Net salary: {netSalary}");

            int y = 18;
           
        }

    }
}