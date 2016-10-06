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
    public class Log 
    {
        [DataMember]
        [Required]
        public string Version { get; set; }

        [DataMember]
        [Required]
        public ICollection<Page> Pages { get; set; }

        [DataMember]
        [Required]
        public Creator Creator { get; set; }

        [DataMember]
        [Required]
        public ICollection<Entry> Entries { get; set; }

    }
}
