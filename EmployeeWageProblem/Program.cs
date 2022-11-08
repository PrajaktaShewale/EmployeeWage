using System;
    namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWage statement");
            Console.WriteLine("1. Emp Attendance" + "\n" + "2. Daily Emp Wage" + "\n" + "3. Part_Full Time Emp Wage" + "\n" + "4. Monthly Emp Wage" + "\n" + "5. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    EmpAttendance at = new EmpAttendance();
                    at.Attendance();
                    break;
                case 2:
                    DailyEmpWage wage = new DailyEmpWage();
                    wage.EmpWage();
                    break;
                case 3:
                    PartTimeEmpWage emp = new PartTimeEmpWage();
                    emp.Emp();
                    break;
                case 4:
                    WagesForMonth em = new WagesForMonth();
                    em.wages();
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;
            }
        }
    }
}