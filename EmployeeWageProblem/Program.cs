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
            const int NUM_0F_WORKING_DAYS = 20;

            int empWage;
            int empHrs = 0;
            int totalEmployeeWage = 0;

            /// By Looping untill Condition reaches
            /// Upto Number of Working Days
            for (int day = 0; day < NUM_0F_WORKING_DAYS; day++)
            {
                /// By Using Switch Case Statement to Compute Employee Wages
                /// Checks if Employee is present
                /// If Employee is Fulltime,it will give Fulltime Employee hours
                /// If Employee is Parttime,it will give Parttime Employee hours
                /// If Employee not present it will give Absent Employee hours ie, zero hours.
                switch (employeeCheck())
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
                empWage = empHrs * EMPLOYEE_RATE_PER_HOUR;
                totalEmployeeWage = totalEmployeeWage + empWage;
                Console.WriteLine("Employee Wage : " + empWage);
            }
            Console.WriteLine("Employee TotalWage : " +totalEmployeeWage);
        }

        /// <summary>
        /// Checks whether Employee present or not
        /// </summary>
        /// <returns></returns>
        public static int employeeCheck()
        {
            /// Create references for Random class
            Random random = new Random();
            /// Returns random value
            return random.Next(0, 3);
        }
    }
}