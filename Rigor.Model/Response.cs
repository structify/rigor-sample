
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
    public class Response 
    {
        //TODO: You could put some input validation to check whether the Status Code is valid
        [DataMember]
        public string StatusCode { get; set; }

        //TODO: You can do some input validation to verify that the Status TExt is valid
        [DataMember]
        public string StatusText { get; set; }

        //TODO: Input validate the HTTP version ??
        [DataMember]
        [Required]
        public string HttpVersion { get; set; }

        [DataMember]
        public ICollection<Header> Headers { get; set; }

        [DataMember]
        public ICollection<Cookie> Cookies { get; set; }

        [DataMember]
        [Required]
        public Content Content { get; set; }

        [DataMember]
        public string RedirectUrl { get; set; }

        [DataMember]
        public long HeaderSize { get; set; }

        [DataMember]
        [Required]
        public long BodySize { get; set; }

        [DataMember]
        [Required]
        public long _TransferSize { get; set; }
    }
}
