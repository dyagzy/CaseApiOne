using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseApi.Domain
{
    public class Case
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateSubmitted { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


    }
}
