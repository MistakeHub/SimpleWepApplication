using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApplication.Domain.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public string Phone { get; set; }


        public List<History> Histories { get; set; } =new List<History>();

        public List<Note> Notes { get; set; } = new List<Note>();

        public List<Employe> Employees { get; set; } = new List<Employe>();
    }
}
