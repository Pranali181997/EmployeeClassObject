using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeObjectClass
{
    class UC5
    {
        public void MonthlySalary()
        {
            int WagePerHr = 20;
            //int FullTime = 2;
            //int PartTime = 1;
            int numberofWorkingDays = 20;
            int FullTimeHr = 8;
            int PartTimeHr = 4;
            int AbsentTimeHr = 0;
            Random random = new Random();
            int number = random.Next(3);
            int DailyWages1 = WagePerHr *= FullTimeHr;
            int DailyWages2 = WagePerHr *= PartTimeHr;
            int DailyWages0 = WagePerHr *= AbsentTimeHr;
            int DailyWages4 = DailyWages1 *= numberofWorkingDays;
            int DailyWages5 = DailyWages2 *= numberofWorkingDays;
            int DailyWages6 = DailyWages0 *= numberofWorkingDays;

            switch (number)
            {

                case 1:
                    Console.WriteLine("Full Time Employee Wages are=" + DailyWages4);
                    break;
                case 2:
                    Console.WriteLine("Part Time Employee Wages are=" + DailyWages5);
                    break;
                default:
                    Console.WriteLine("Employee Is Absent Then Wages are=" + DailyWages6);
                    break;
            }

        }
    }

}

