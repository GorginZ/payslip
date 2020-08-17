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
            //function from payslip input class (called payslip)
            Console.WriteLine(PayslipInput.NameConcat(testSlip.FirstName, testSlip.LastName));

            
        }
    }
}
  