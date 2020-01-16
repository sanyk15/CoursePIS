using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class AgentContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int AgentId { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public double Commission { get; set; }
        [DataMember]
        public bool Status { get; set; }
        public virtual User Agent { get; set; }

        [ForeignKey("AgentId")]
        public virtual List<ClientContract> ClientContracts { get; set; }
    }
}