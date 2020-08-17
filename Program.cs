using System;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Write your First Name");
            var testSlip = new PayslipInput();
            testSlip.FirstName = Console.ReadLine();
            Console.WriteLine("Please Write your Last Name");
            testSlip.LastName = Console.ReadLine();
            Console.WriteLine($"your first name is {testSlip.FirstName} and your last name is {testSlip.LastName}");
            
        }
    }
}
    // public string PayPeriod { get; set; }
    //     public string Grossincome { get; set; }
    //     public string IncomeTax { get; set; }
    //     public string NetIncome { get; set; }
    //     public string Super { get; set; }