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
    public class Header 
    {
        [DataMember]
        [Required]
        public string Name { get; set; }

        [DataMember]
        [Required]
        public string Value { get; set; }

    }
}
