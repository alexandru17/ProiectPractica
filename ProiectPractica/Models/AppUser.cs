using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ProiectPractica.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser(string? numeComplet, ICollection<ResponsabilProiect> proiecteRepartizate)
        {
            NumeComplet = numeComplet;
            ProiecteRepartizate = proiecteRepartizate;
        }

        public string? NumeComplet { get; set; }

        // Proiecte la care userul are acces (este responsabil / manager)
        public ICollection<ResponsabilProiect> ProiecteRepartizate { get; set; }
    }

}
