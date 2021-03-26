using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rohm.Pricer.Models
{
    public class Job
    {
        public bool Enabled { get; set; }
        public string ExternalId { get; set; }
        public JobFrequency Frequency { get; set; }
        public int Id { get; set; }
        public string JobType { get; set; }
        public string LastRun { get; set; }
        public string Name { get; set; }
        public JobParameters Parameters { get; set; }
        public bool Running { get; set; }
        public string Start { get; set; }
    }
}
