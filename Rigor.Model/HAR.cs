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
    public class HAR 
    {
        [DataMember]
        [Required]
        public Log Log { get; set; }

    }
}
