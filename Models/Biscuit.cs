using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using System.Xml.Linq;

namespace Rusu_Iuliana_ECTS.Models
{
    public class Biscuit
    {
        public int ID { get; set; }
            
        [Display(Name = "Denumirea prajiturii")]
        public string Denumire { get; set; }
        public string Ingrediente { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        [DataType(DataType.Date)]

        [Display(Name = "Data expirarii")]
        public DateTime DataExpirarii { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property
   
    }
}
