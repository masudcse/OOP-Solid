using SOLID;
using System.Net.Http.Headers;

namespace OOP
{
    class Program
    {
        public IPrinterOrigin _iprinterOrigin;
        public Program(IPrinterOrigin printerOrigin)
        {
            _iprinterOrigin = printerOrigin;
        }
        static void Main(string[] args)
        {
            #region SRP
            var basicInfo = new BasicInfo
            {
                Id = 1,
                StaffName = "Mia Mahmudunnabi",
                StaffAddress = "Setapak",
                ContactNo = "601123208993"
            };

            var officialInfo = new OfficialInfo
            {
                Department="SWE",
                Designation="Technical Lead",
                JoiningDate= DateTime.Parse("2021-10-01"),
                Grade=1,
                SkillSet="DotNet & Azure"
            };
            var payrollInof = new PayrollInfo 
            {
                BasicSalary=10000,
                AdditionalSalary=2000,
                GrossSalary=12000
            };

            var personalInfo = new PersonalInfo
            {
                DateofBirth = DateTime.Parse("1988-05-05"),
                Gender="Male",
                MaritalStatus="Married",
                Hobby="Hangout"
            };

            Console.WriteLine($"{basicInfo.Id} {basicInfo.StaffName} {basicInfo.StaffAddress} {basicInfo.ContactNo}");
            #endregion

            GetPrinterHP hpPrinter = new GetPrinterHP();
            GetPrinterDell dellPrinter = new GetPrinterDell();
            GetPrinterAcer acerPrinter = new GetPrinterAcer();
            GetPrinterLenovo lenovoPrinter = new GetPrinterLenovo();
           
            Console.WriteLine(hpPrinter.GetPrinterName("HP"));   // Output: HP Printer Origin from America
            Console.WriteLine(dellPrinter.GetPrinterName("Dell")); // Output: Dell Printer Origin from America
            Console.WriteLine(acerPrinter.GetPrinterName("Acer")); // Output: Acer Printer Origin from Taiwan
            Console.WriteLine(lenovoPrinter.GetPrinterName("Lenovo"));



        }
    }
}