using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace ProiectPractica.Models
{
    public class Proiect
    {
        public Proiect(int proiectId, string numeClient, string domeniul, string obiectulContractului, DateTime dataSemnareContract, DateTime dataIncheiereContract, StatusProiect status, bool existaAmendamente, int numarAmendamente, bool esteClientPublic, bool areSubcontractor, int numarubcontaractori, decimal valoareContract, ICollection<ActAditional> acteAditionale, ICollection<TaskProiect> taskuri, ICollection<Livrabil> livrabile, ICollection<Subcontractor> subcontractori, ICollection<ResponsabilProiect> responsabili)
        {
            ProiectId = proiectId;
            NumeClient = numeClient;
            Domeniul = domeniul;
            ObiectulContractului = obiectulContractului;
            DataSemnareContract = dataSemnareContract;
            DataIncheiereContract = dataIncheiereContract;
            Status = status;
            ExistaAmendamente = existaAmendamente;
            NumarAmendamente = numarAmendamente;
            EsteClientPublic = esteClientPublic;
            AreSubcontractor = areSubcontractor;
            Numarubcontaractori = numarubcontaractori;
            ValoareContract = valoareContract;
            ActeAditionale = acteAditionale;
            Taskuri = taskuri;
            Livrabile = livrabile;
            Subcontractori = subcontractori;
            Responsabili = responsabili;
        }


        public int ProiectId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nume client")]
        public string NumeClient { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Domeniul proiectului")]
        public string Domeniul { get; set; }

        [StringLength(500)]
        public string ObiectulContractului { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data semnare contract")]
        public DateTime DataSemnareContract { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data încheiere contract")]
        public DateTime DataIncheiereContract { get; set; }

        [Required]
        [StringLength(50)]
        public StatusProiect Status { get; set; }

        [Required]
        [Display(Name = "Este amendat?")]
        public bool ExistaAmendamente { get; set; }

        [Display(Name = "Număr amendamente")]
        [Range(0, int.MaxValue, ErrorMessage = "Numărul de amendamente trebuie să fie pozitiv.")]
        public int NumarAmendamente { get; set; }

        
        

        [Required]
        [Display(Name = "Este client public?")]
        public bool EsteClientPublic { get; set; }

        [Required]
        [Display(Name = "Are subcontractor?")]
        public bool AreSubcontractor { get; set; }

        [Display(Name = "Număr subcontractori")]
        [Range(0, int.MaxValue, ErrorMessage = "Numărul de subcontractori trebuie să fie pozitiv.")]
        public int Numarubcontaractori { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal ValoareContract { get; set; }

        // Relații
        public ICollection<ActAditional> ActeAditionale { get; set; }
        public ICollection<TaskProiect> Taskuri { get; set; }
        public ICollection<Livrabil> Livrabile { get; set; }

        public ICollection<Subcontractor> Subcontractori { get; set; }

        public ICollection<ResponsabilProiect> Responsabili { get; set; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}

