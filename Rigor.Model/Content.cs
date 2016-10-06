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
    public class Content 
    {
        [DataMember]
        [Required]
        public long Size { get; set; }

        [DataMember]
        [Required]
        public string MimeType { get; set; }

        [DataMember]
        public long Compression { get; set; }

        [DataMember]
        public string Text { get; set; }
    }
}
