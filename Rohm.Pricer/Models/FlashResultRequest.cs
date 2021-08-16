using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class FlashResultRequest
    {
        public FlashResultRequestItem[] Items { get; set; }
        public string Status { get; set; }
    }
}
