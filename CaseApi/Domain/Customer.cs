using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseApi.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public IEnumerable<Case> Cases { get; set; }
    }
}
