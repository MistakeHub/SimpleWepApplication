using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SimpleWebApplication.Domain.Models
{
    public class Employe
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime BirthDate { get; set; }

        public string Position { get; set; }

        [ForeignKey("CompanyId")]
        [JsonIgnore]
        public Company Company { get; set; }

      


    }
}
