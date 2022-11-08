using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class WagesForMonth
    {
        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, PART_TIME_HR = 4,
            IS_FULL_TIME = 1, IS_PART_TIME = 2, TOTAL_WORKING_DAYS = 20;
        Random random = new Random();
        public void wages()
        {
            int totalEmpWage = 0, empHrs = 0;
            for (int i = 0; i < TOTAL_WORKING_DAYS; i++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs += FULL_DAY_HR;
                        break;
                    case IS_PART_TIME:
                        empHrs += PART_TIME_HR;
                        break;
                    default:
                        empHrs += 0;
                        break;
                }
            }

            totalEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Monthly Emp Wage" + totalEmpWage);

        }

    }
}
