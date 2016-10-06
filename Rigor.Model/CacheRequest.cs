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
    public class CacheRequest 
    {
        [DataMember]
        public DateTime? Expires { get; set; }

        [DataMember]
        [Required]
        public DateTime LastAccess { get; set; }

        [DataMember]
        [Required]
        public string ETag { get; set; }

        [DataMember]
        [Required]
        public long HitCount { get; set; }

        [DataMember]
        public string Comment { get; set; }

    }
}
