using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleWebApplication.Domain.Models
{
    public class Note
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string InvoiceNumber { get; set; }

        public int EmployeId { get; set; }

        [ForeignKey("EmployeId")]
        
        public virtual Employe Employe { get; set; }

        [ForeignKey("CompanyId")]
        [JsonIgnore]
        public virtual Company Company { get; set; }


    }
}
