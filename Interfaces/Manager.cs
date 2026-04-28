using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Manager : Employee, IManager
    {
        public string OfficeId { get; set; }
        public string SecretaryId { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}OfficeId: {OfficeId}, {Environment.NewLine}SecretaryId: {SecretaryId}";
        }
    }
}
