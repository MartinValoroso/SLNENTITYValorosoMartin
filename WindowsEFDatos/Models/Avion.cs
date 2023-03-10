using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFDatos.Models
{
    [Table("Avion")]
    public class Avion
    {
        [Key]
        public int AvionID { get; set; }

        public int Capacidad { get; set; }

        [Column(TypeName ="varchar")]
        [StringLength(50)]
        [Required]
        public string Demonimacion { get; set; }


        public int IdLinea { get; set; }

        [ForeignKey("IdLinea")]
        public LineaAerea LineaAerea { get; set; }


    }
}
