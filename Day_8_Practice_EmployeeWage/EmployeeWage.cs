using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_Practice_EmployeeWage
{
    public class EmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_WORKING_DAY = 20;
        public const int MAX_WORKING_HRS = 100;
        public void EmployeeDetails()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalemphrs = 0;
            int totalworkingday = 0;

            while (totalemphrs <= MAX_WORKING_HRS && totalworkingday <= NUM_WORKING_DAY)
            {
                totalworkingday++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empWage)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalemphrs += empHrs;

                Console.WriteLine("Day :" + totalworkingday + "emp hrs" + empHrs);
            }
            totalEmpWage = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Empolyee Wage :" + totalEmpWage);

        }
    }
}



