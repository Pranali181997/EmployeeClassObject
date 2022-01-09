using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeObjectClass
{
    class UC4
    {
        public void SwitchCase()
        {
            int WagePerHr = 20;
            //int FullTime = 2;
            //int PartTime = 1;
            int FullTimeHr = 8;
            int PartTimeHr = 4;
            int AbsentTimeHr = 0;
            Random random = new Random();
            int number = random.Next(3);
            int DailyWages1 = WagePerHr *= FullTimeHr;
            int DailyWages2 = WagePerHr *= PartTimeHr;
            int DailyWages0 = WagePerHr *= AbsentTimeHr;

            switch (number)
            {

                case 1:
                    Console.WriteLine("Full Time Employee Wages are=" + DailyWages1);
                    break;
                case 2:
                    Console.WriteLine("Part Time Employee Wages are=" + DailyWages2);
                    break;
                default:
                    Console.WriteLine("Employee Is Absent Then Wages are=" + DailyWages0);
                    break;
            }
        }
    }

}

    

