using System.ComponentModel.DataAnnotations;
using ProiectPractica.Models;

namespace ProiectPractica.Models
{
    public class TaskProiect
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Descriere { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataStart { get; set; }

        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }  // Ex: "To Do", "In Progress", "Done"

        [StringLength(100)]
        public string? Responsabil { get; set; }

        public bool EsteNotificare { get; set; }

        public TaskProiect(int id, string descriere, DateTime dataStart, DateTime deadline, string status, string? responsabil, bool esteNotificare, int proiectId, Proiect proiect)
        {
            Id = id;
            Descriere = descriere;
            DataStart = dataStart;
            Deadline = deadline;
            Status = status;
            Responsabil = responsabil;
            EsteNotificare = esteNotificare;
            ProiectId = proiectId;
            Proiect = proiect;
        }

        public TaskProiect()
        {
        }

        // Legătură cu Proiectul
        public int ProiectId { get; set; }
        public Proiect Proiect { get; set; }
    }
}
