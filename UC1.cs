using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeObjectClass
{
    class UC1
    {
        public void PresentOrNot()
        {
            Random random = new Random();
            int number = random.Next(2);
            {
                if (number == 0)
                {
                    Console.WriteLine("Empl is Present");
                }
                else
                {
                    Console.WriteLine("Empl is Absent");
                }

            }
        }
    }
}

    

