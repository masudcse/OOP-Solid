using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    /// <summary>
    /// Seperate based on related concern/purpose
    /// </summary>
    public class BasicInfo
    {
        //Basic Info
        public int Id { get; set; }
        public string StaffName { get; set; }
        public string StaffAddress { get; set; }
        public string ContactNo { get; set; }
    }

    public class OfficialInfo
    {
        public string Designation { get; set; }
        public int Grade { get; set; }
        public string Department { get; set; }
        public DateTime JoiningDate { get; set; }
        public string SkillSet { get; set; }
    }
    public class PayrollInfo
    {
        public double BasicSalary { get; set; }
        public double AdditionalSalary { get; set; }
        public double GrossSalary { get; set; }
    }

    public class PersonalInfo
    {
        public string Hobby { get; set; }
        public DateTime DateofBirth { get; set; }
        public string MaritalStatus { get; set; }

        public string Gender { get; set; }
    }
}
