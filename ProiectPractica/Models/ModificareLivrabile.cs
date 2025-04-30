namespace ProiectPractica.Models
{
    public class ModificareLivrabile : ActAditional
    {
        public string DescriereSchimbare { get; set; }

        public bool EsteAdaugare { get; set; } // true = adăugare, false = eliminare
    }
}
