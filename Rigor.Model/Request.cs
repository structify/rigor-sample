
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
    public class Request 
    {
        //TODO: You could put some input validation to check whether hte Method is a valid HTTP method
        [DataMember]
        [Required]
        public string Method { get; set; }

        //TODO: You can do some input validation to verify that the Url is a valid uri
        [DataMember]
        [Required]
        public string Url { get; set; }

        //TODO: Input validate the HTTP version ??
        [DataMember]
        [Required]
        public string HttpVersion { get; set; }

        [DataMember]
        public ICollection<Header> Headers { get; set; }

        [DataMember]
        public ICollection<QueryStringParam> QueryString { get; set; }

        [DataMember]
        public ICollection<Cookie> Cookies { get; set; }

        [DataMember]
        public long HeaderSize { get; set; }

        [DataMember]
        [Required]
        public long BodySize { get; set; }
    }
}
