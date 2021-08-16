using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class FlashItemRequest
    {
        public FlashItemRequestConfiguration Configuration { get; set; }
        public string[] ItemIds { get; set; }
    }
}
