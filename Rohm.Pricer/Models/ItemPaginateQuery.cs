using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class ItemPaginateQuery
    {
        public int Limit { get; set; }
        public string Projection { get; set; }
        public int Start { get; set; }
    }
}
