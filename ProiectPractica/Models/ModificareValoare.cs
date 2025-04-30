using System.ComponentModel.DataAnnotations;

namespace ProiectPractica.Models
{
    public class ModificareValoare : ActAditional
    {
        [Required]
        [Range(0, double.MaxValue)]
        public decimal ValoareNoua { get; set; }

        public string? Motiv { get; set; }
    }
}
