using System;
namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int WAGE_PER_HR=20,FULL_DAY_HR=8;
        Random random = new Random();
        public void Attendance()
        {
            int empCheck = random.Next(0,2);
            if (empCheck == 0)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void EmpWage()
        {
            int totalEmpWage = 0;
                int empCheck = random.Next(0, 2);
            if (empCheck == 0)            
            totalEmpWage = WAGE_PER_HR * FULL_DAY_HR;
            Console.WriteLine("Daily Emp Wage is " + totalEmpWage);

        }

    }
}