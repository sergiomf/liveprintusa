using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace liveprintusa.Entity
{
    [DataContract]
    public class PrintRequest
    {
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public string CustomerKey { get; set; }
        [DataMember]
        public string CustomerData { get; set; } // Json format: RefereceNumber, Sender , DestinationName, DestinatioAddress, DestinatioCity, DestinatioState, DestinatioZipcode
        [DataMember]
        public byte[] Body { get; set; }

    }
}