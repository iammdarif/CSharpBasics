using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IChiefExecutiveOfficer
    {
        public string PersonalAssistant { get; set; }
    }
    public class ChiefExecutiveOfficer : Manager, IChiefExecutiveOfficer
    {
        public string PersonalAssistant { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}PersonalAssistant: {PersonalAssistant}";
        }
    }
}
