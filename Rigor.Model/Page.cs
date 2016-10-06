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
    public class Page 
    {
        [DataMember]
        [Required]
        public DateTime StartedDateTime { get; set; }

        [DataMember]
        [Required]
        public string Id { get; set; }

        [DataMember]
        [Required]
        public string Title { get; set; }

        [DataMember]
        [Required]
        public PageTiming PageTimings { get; set; }

    }
}
