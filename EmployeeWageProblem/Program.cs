using System;

namespace EmployeeWageProblem
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            const int IS_EMPLOYEE_FULL_TIME = 1;
            const int IS_EMPLOYEE_PART_TIME = 2;
            const int EMPLOYEE_RATE_PER_HOUR = 20;
            const int NUM_0F_WORKING_DAYS = 2;
            const int MAX_HOURS_IN_MONTH = 20;

            int empHrs = 0;
            int totalEmployeeHours = 0;
            int totalEmployeeWages = 0;
            int totalWokingDays = 0;
            
            int empHrs = 0;
            int totalEmployeeHours = 0;
            int totalEmployeeWages = 0;
            int totalWokingDays = 0;

            /// By Looping untill Condition reaches
            /// Upto Number of Working Days
            while(empHrs <= MAX_HOURS_IN_MONTH && totalWokingDays <= NUM_0F_WORKING_DAYS)
            {
                /// By Using Switch Case Statement to Compute Employee Wages
                /// Checks if Employee is present
                /// If Employee is Fulltime,it will give Fulltime Employee hours
                /// If Employee is Parttime,it will give Parttime Employee hours
                /// If Employee not present it will give Absent Employee hours ie, zero hours.
                switch (EmployeeCheck())
                {
                    case IS_EMPLOYEE_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_EMPLOYEE_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmployeeHours = totalEmployeeHours + empHrs;
                Console.WriteLine("Day :"+totalWokingDays+"  Employee Hour :"+empHrs);
                totalWokingDays++;
            }
            totalEmployeeWages = totalEmployeeHours * EMPLOYEE_RATE_PER_HOUR;
            Console.WriteLine("Employee TotalWage : " + totalEmployeeWages);
        }

        /// <summary>
        /// Checks whether Employee present or not
        /// </summary>
        /// <returns></returns>
        public static int EmployeeCheck()
        {
            /// Create references for Random class
            Random random = new Random();
            /// Returns random value
            return random.Next(0, 3);
        }
    }
}
