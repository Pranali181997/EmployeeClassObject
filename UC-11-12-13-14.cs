using System;
using EmployeeWageComputationProblem;
using System.Collections.Generic;
using System.Text;

namespace EmployeeObjectClass
{
    public class EmpWageBuilder : IComputeEmpWage
    {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private LinkedList<CompanyEmpWage> companyEmpWageList;
            private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

            public EmpWageBuilder()
            {
                this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
                this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
            }

            public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
            CompanyEmpWage computeEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
                this.companyEmpWageList.AddLast(computeEmpWage);
                this.companyToEmpWageMap.Add(company, computeEmpWage);
            }

            public void ComputeEmpWage()
            {
                foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
                {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                    Console.WriteLine(companyEmpWage.toString());
                }
            }

            private int computeEmpWage(CompanyEmpWage computeEmpWage)
            {
                //Variables
                int empHrs = 0;
                int totalEmpHrs = 0;
                int totalWorkingHrs = 0;

                while (totalWorkingHrs < computeEmpWage.numOfWorkingDays && totalEmpHrs <= computeEmpWage.maxHoursPerMonth)
                {
                    totalWorkingHrs++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs = totalEmpHrs + empHrs;
                    Console.WriteLine("Day# : " + totalWorkingHrs + " Emp Hrs : " + empHrs);

                }
                int totalEmpWage = totalEmpHrs * computeEmpWage.empRatePerHour;
                return totalEmpWage;

            }

            public int getTotalWage(string company)
            {
                return this.companyToEmpWageMap[company].totalEmpWage;
            }
        }
    }

