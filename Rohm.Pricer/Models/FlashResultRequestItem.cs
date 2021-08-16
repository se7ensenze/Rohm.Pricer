using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class FlashResultRequestItem
    {
        public string ItemId { get; set; }
        public BarcodeStatus[] Labels { get; set; }
        public string Status { get; set; }
    }
}
