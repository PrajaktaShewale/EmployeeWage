using System;
namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        const int WAGE_PER_HR=20,FULL_DAY_HR=8,PART_TIME_HR=4,IS_PRESENT=0,
            IS_FULL_TIME=1,IS_PART_TIME=2;
        Random random = new Random();
        public void Attendance()
        {
            Random random = new Random();//inbuild class and has methods
            int empCheck = random.Next(0,2);//0,1
            if (empCheck == 0)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
        public void EmpWage()
        { 
        int dailyEmpWage = 0,empHrs=0;
            int empCheck = random.Next(0, 3);//0,1,2
            if (empCheck == IS_FULL_TIME)
                empHrs = FULL_DAY_HR;
            else if (empCheck == IS_PART_TIME)
                empHrs = PART_TIME_HR;
            else
                empHrs = 0;
            dailyEmpWage = WAGE_PER_HR * empHrs;
            Console.WriteLine("Daily Emp Wage" + dailyEmpWage);

        }

    }
}