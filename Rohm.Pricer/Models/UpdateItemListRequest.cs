using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class UpdateItemListRequest
    {
        public string Department { get; set; }
        public string ItemGroup { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Presentation { get; set; }
        public string Price { get; set; }
        public UpdateItemListRequestProperty Properties { get; set; }
        public string[] Sics { get; set; }
        public string ValidFrom { get; set; }
    }
}
