using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Statement
    {
        public int Id { get; set; }
        public int AccountantId { get; set; }
        public double Salary { get; set; }
        public string Date { get; set; }
        public string Period { get; set; }

        public virtual User Accountant { get; set; }

        [ForeignKey("StatementId")]
        public virtual List<TableStatement> TableStatements { get; set; }
    }
}