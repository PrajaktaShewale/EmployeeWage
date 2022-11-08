using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class DailyEmpWage
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8;
        Random random = new Random();
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
