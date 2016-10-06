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
    public class Entry 
    {
        [DataMember]
        [Required]
        public DateTime StartedDateTime { get; set; }

        [DataMember]
        [Required]
        public long Time { get; set; }

        [DataMember]
        [Required]
        public Request Request { get; set; }

        [DataMember]
        public Response Response { get; set; }

        [DataMember]
        public Cache Cache { get; set; }

        [DataMember]
        [Required]
        public Timing Timings { get; set; }

        //TODO: validate proper IP format?
        [DataMember]
        public string ServerIPAddress { get; set; }

        [DataMember]
        public string Connection { get; set; }

        [DataMember]
        [Required]
        public string Pageref { get; set; }
    }
}
