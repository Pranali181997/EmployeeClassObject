using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeObjectClass
{
        public class UC8_EmpWageForMultipleCompanies
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                //Variables
                int empHrs = 0;
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;
                //Computation
                while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
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
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day:" + totalWorkingDays + "Emp Hours : " + empHrs);
                }
                int totalEmpWage = totalEmpHrs * empRatePerHour;
                Console.WriteLine("Total Emp Wage for company : " + company + " is: " + totalEmpWage);
                return totalEmpWage;
            }
        }
    }
