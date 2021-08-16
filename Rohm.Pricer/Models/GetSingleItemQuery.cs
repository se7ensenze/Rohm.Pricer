using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class GetSingleItemQuery
    {
        public string ItemId { get; set; }
        public string Projection { get; set; }
    }
}
