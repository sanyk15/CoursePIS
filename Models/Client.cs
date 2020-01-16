using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public string Passport { get; set; }

        [ForeignKey("ClientId")]
        public virtual List<ClientContract> ClientContracts { get; set; }
    }
}