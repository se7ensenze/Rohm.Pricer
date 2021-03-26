using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class DisplayPageRequest
    {
        public DisplayPageRequestConfiguration Configuration { get; set; }
        public string[] Barcodes { get; set; }
    }
}
