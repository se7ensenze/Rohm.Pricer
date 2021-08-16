using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class FlashResultResponse
    {
        public BarcodeStatus[] FlashResults { get; set; }
        public string Status { get; set; }
    }
}
