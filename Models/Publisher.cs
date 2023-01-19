using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Rusu_Iuliana_ECTS.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Display(Name = "Cantitate")]
        public string PublisherName { get; set; }
        [Display(Name = "Denumire produs")]
        public string Denumire_produs;
        public ICollection<Biscuit>? Biscuits { get; set; } //navigation property
    }
}
