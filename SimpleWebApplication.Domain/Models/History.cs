using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleWebApplication.Domain.Models
{
    public class History
    {

        public int Id { get; set; }

        public int CompanyId { get; set; }

        public DateTime OrderDate { get; set; }

        public string StoreCity { get; set; }

        [ForeignKey("CompanyId")]
        [JsonIgnore]
        public Company Company { get; set; }


    }
}
