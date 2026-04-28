using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Employee : IEmployee
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual decimal AnnualSalary { get; set; }
        public char Gender { get; set; }
        public DateTime JoinDate { get; set; }
        public string HighestQualification { get; set; }

        public string GetBasicInfo()
        {
            return $"Id: {Id}, {Environment.NewLine}JobTitle: {JobTitle}, {Environment.NewLine}FirstName: {FirstName},{Environment.NewLine}LastName: {LastName}, {Environment.NewLine}AnnualSalary: {AnnualSalary}, {Environment.NewLine}Gender: {Gender}, {Environment.NewLine}JoinDate: {JoinDate}, {Environment.NewLine}HighestQualification: {HighestQualification}";
        }

        public override string ToString()
        {
            return GetBasicInfo();
        }

        public int GetFullYearsWorked()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);

            TimeSpan span = DateTime.Now.Subtract(JoinDate);
            int years = zeroTime.Add(span).Year - 1;

            return years;
        }
    }
}
