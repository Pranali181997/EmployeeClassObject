using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeObjectClass
{
    class UC2
    {
        public void DailyWages()
        {
            Random random = new Random();
            int number = random.Next(2);
            {
                if (number == 0)
                {
                    int WagePerHr = 20;
                    int FullDayHr = 8;
                    int DailyWages = WagePerHr *= FullDayHr;
                    {
                        Console.WriteLine("Daily Employee Wages are=" + DailyWages);
                    }
                }
                else
                {
                    int DailyWages = 0;
                    Console.WriteLine("Daily Employee Wages are=" + DailyWages);
                }
            }
        }
    }
}
    

