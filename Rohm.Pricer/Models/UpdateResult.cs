using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class UpdateResult
    {
        public object Body { get; set; }
        public string StatusCode { get; set; }
        public int StatusCodeValue { get; set; }
    }
}
