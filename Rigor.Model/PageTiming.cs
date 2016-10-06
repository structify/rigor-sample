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
    public class PageTiming 
    {
        [DataMember]
        [Required]
        public double OnContentLoad { get; set; }

        [DataMember]
        [Required]
        public double OnLoad { get; set; }

       
    }
}
