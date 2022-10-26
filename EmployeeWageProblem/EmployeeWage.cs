using System;
namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        public void Attendance()
        {
            Random random = new Random();//inbuild class and has methods
            int empCheck = random.Next(0,2);//0,1
            if (empCheck == 0)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}