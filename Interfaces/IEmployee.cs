using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEmployee
    {
        int Id { get; set; }
        string JobTitle { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal AnnualSalary { get; set; }
        char Gender { get; set; }
        DateTime JoinDate { get; set; }
        string HighestQualification { get; set; }

        string GetBasicInfo();
        int GetFullYearsWorked();

        string GetAdditionalInfo()
        { 
            return $"Additional info for employee with id: {Id} Gender: {Gender} Highest Qualification: {HighestQualification}";
        }
    }
}
