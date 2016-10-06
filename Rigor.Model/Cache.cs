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
    public class Cache 
    {
        [DataMember]
        public CacheRequest BeforeRequest { get; set; }

        [DataMember]
        public CacheRequest AfterRequest { get; set; }

        [DataMember]
        public string Comment { get; set; }

    }
}
