using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeObjectClass
{
    class UC3

    {
        public void PartTime()
        {
            Random random = new Random();
            int number = random.Next(3);
            {
                int WagePerHr = 20;
                int FullTime = 2;
                int PartTime = 1;
                //int AbsentTimeHr = 0;
                //int DailyWages = WagePerHr *= FullTimeHr;
                if (number == FullTime)
                {
                    int FullTimeHr = 8;
                    int DailyWages = WagePerHr *= FullTimeHr;
                    Console.WriteLine("Full Time Employee Wages are=" + DailyWages);
                }
                else if (number == PartTime)
                {
                    int PartTimeHr = 4;
                    int DailyWages = WagePerHr *= PartTimeHr;

                    Console.WriteLine("Part Time Employee Wages are=" + DailyWages);
                }
                else
                {
                    int DailyWages = 0;
                    Console.WriteLine("Employee Is Absent Then Wages are=" + DailyWages);
                }
            }
        }
    }
}

    
    

