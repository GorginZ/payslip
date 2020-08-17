using System;
using System.Text;

namespace Payslip
{
  public class PayslipInput
    {
        public string FirstName { get; set; }
         public string LastName { get; set; }

        public string SuperRate { get; set; }
        public string PaymentStart { get; set; }
        public string PaymentEnd { get; set; }
        //access modifiers
        private string _annualSalary;
        public string AnnualSalary

        {
            get { return _annualSalary; }
            set
            { //regex will go below, to handle invalid input
                if (value.StartsWith("#"))
                {
                    _annualSalary = value;
                }
                else
                {
                    throw new Exception("Your salary must include numbers only");
                }
            }
        }
    
        //want to assign to the format/fields of output as specified in challenge eg name not first and last name
        public PayslipInput(string FirstName, string LastName, string SuperRate, string PaymentStart, string PaymentEnd, string AnnualSalary)
        {
           Name = NameConcat(FirstName, LastName);
           PayPeriod = PeriodConct( PaymentStart, PaymentEnd);
           Grossincome = "something";
           IncomeTax = "someting";
           NetIncome = "something";
           SuperRate ="SUPER";
        }
        //function to concat first and last name for expected 'name' field in payslip 
        public static string NameConcat(string FirstName, string LastName) => $"{FirstName} {LastName}";
        //arrow function to concat entered payment periods in format expected in pay period field in payslip
        public static string PeriodConcat(string PaymentStart, string PaymentEnd) => $"{PaymentStart}-{PaymentEnd}";

    }
}
