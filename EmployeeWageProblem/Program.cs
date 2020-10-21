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

            /// Checks if Employee is present,it will give Present message
            /// IF Employee not present it will give Absent message
            if(employeeCheck() == IS_EMPLOYEE_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
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
            return random.Next(0, 2);
        }
    }
}
