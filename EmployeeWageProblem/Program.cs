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

            int empHrs = 0;
            int empWage;

            /// Checks if Employee is present
            /// If Employee is Fulltime,it will give Fulltime Employee hours
            /// If Employee is Parttime,it will give Parttime Employee hours
            /// If Employee not present it will give Absent Employee hours ie, zero hours.
            if (employeeCheck() == IS_EMPLOYEE_FULL_TIME)
            {
                empHrs = 8;
            }
            else if(employeeCheck() == IS_EMPLOYEE_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMPLOYEE_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage : " + empWage);
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
            return random.Next(0,3);
        }
    }
}