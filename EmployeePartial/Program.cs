using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePartial
{
    public partial class Employee {











        static void Main(string[] args)
        {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BaseSalary { get; set; }
        public int HourWorked { get; set; }
        public decimal HourlyRate { get; set; }

    }
    public partial class Employee {

        public decimal CalculateMonthSalary()
        {
            return BaseSalary;
        }
        public decimal CalculateHourlySalary()
        {
            return HourWorked * HourlyRate;
        }
        public decimal CalculateOvertimeSalary(decimal overtimeRate)
        {
            int overtimeHours = HourWorked - 40;
            if (overtimeHours > 0)
            {
                decimal overtimePay = overtimeHours * overtimeRate;
                decimal regularPay = 40 * HourlyRate;
                return regularPay + overtimePay;

            }
            else
            {
                return CalculateHourlySalary();
            }
        }
    }


}

