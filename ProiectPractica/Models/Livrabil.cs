using System.ComponentModel.DataAnnotations;
using ProiectPractica.Models;

namespace ProiectPractica.Models
{
    public class Livrabil
    {
        public Livrabil()
        {
        }

        public Livrabil(int id, string nume, string? descriere, DateTime dataEstimata, bool estePredat, int proiectId, Proiect proiect)
        {
            Id = id;
            Nume = nume;
            Descriere = descriere;
            DataEstimata = dataEstimata;
            EstePredat = estePredat;
            ProiectId = proiectId;
            Proiect = proiect;
        }

        [Key] // opțional, dar recomandat
        public int Id { get; set; }

        [Required]
        public string Nume { get; set; }

        public string? Descriere { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataEstimata { get; set; }

        public bool EstePredat { get; set; }

        // Legătură cu proiectul
        public int ProiectId { get; set; }
        public Proiect Proiect { get; set; }
    }
}
