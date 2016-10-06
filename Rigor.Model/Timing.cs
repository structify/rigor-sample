using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Rigor.Model
{
    [DataContract]
    public class Timing 
    {
        [DataMember]
        [Required]
        public double Blocked { get; set; }

        [DataMember]
        [Required]
        public double Dns { get; set; }

        [DataMember]
        [Required]
        public double Connect { get; set; }

        [DataMember]
        [Required]
        public double Send { get; set; }

        [DataMember]
        [Required]
        public double Wait { get; set; }

        [DataMember]
        [Required]
        public double Receive { get; set; }

        [DataMember]
        [Required]
        public double SSL { get; set; }
    }
}
