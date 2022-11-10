using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem statement");
            MultipleCompany.computeEmpWage("Reliance", 20, 22, 25);
            MultipleCompany.computeEmpWage("TATA", 80, 22, 10);
        }
    }
}