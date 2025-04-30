
using System.ComponentModel.DataAnnotations;
using ProiectPractica.Models;

namespace ProiectPractica.Models
{
    public class Subcontractor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nume { get; set; }

        [Required]
        [StringLength(100)]
        public string Domeniu { get; set; }


        public int ProiectId { get; set; }
        public Proiect Proiect { get; set; }

        // Poți adăuga și alte câmpuri dacă vrei
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Telefon { get; set; }
    }
}



