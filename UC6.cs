using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeObjectClass
{
    class UC6
    {
        public void EmpDailyWage4()
        {

            int maxRateInMonth = 100;
            int empRatePerHr = 20;
            int numOfWorkingDays = 20;
            int totalEmpHr = 0;
            int totalWorkingDays = 0;

            while (totalEmpHr <= maxRateInMonth && totalWorkingDays <= numOfWorkingDays)
            {
                totalEmpHr++;
                Random random = new Random();
                int number = random.Next(3);
                switch (number)
                {
                    case 1:
                        int isPartTimeHrs = 4;
                        totalEmpHr = (totalEmpHr + isPartTimeHrs);
                        break;
                    case 2:
                        int isFullTimeHrs = 8;
                        totalEmpHr = (totalEmpHr + isFullTimeHrs);
                        break;
                    default:
                        int absentHrs = 0;
                        totalEmpHr = (totalEmpHr + absentHrs);
                        break;
                }
                int totalSalary = totalEmpHr * empRatePerHr;
                Console.WriteLine("Total salary of an Employee is " + totalSalary);
            }
        }
    }
}

    

