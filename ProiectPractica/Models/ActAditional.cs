using System.ComponentModel.DataAnnotations;
using ProiectPractica.Models;

namespace ProiectPractica.Models
{
    public abstract class ActAditional
    {
        public int Id { get; set; }

        // Legătura cu Proiect
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataAct { get; set; }
        public int ProiectId { get; set; }
        public Proiect Proiect { get; set; }
    }
}
