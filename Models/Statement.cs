using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Statement
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public double Salary { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Period { get; set; }

        [ForeignKey("StatementId")]
        public virtual List<TableStatement> TableStatements { get; set; }
    }
}