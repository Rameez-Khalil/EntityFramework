using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain
{

    public  class Coach : DomainObject
    {
        public int CoachId { get; set; }
        public string CoachName { get; set; }
    }
}
