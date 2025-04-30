namespace ProiectPractica.Models
{
    public class ResponsabilProiect
    {
        public ResponsabilProiect(int id, string appUserId, AppUser appUser, int proiectId, Proiect proiect, DateTime dataAtribuire)
        {
            Id = id;
            AppUserId = appUserId;
            AppUser = appUser;
            ProiectId = proiectId;
            Proiect = proiect;
            DataAtribuire = dataAtribuire;
        }

        public int Id { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int ProiectId { get; set; }
        public Proiect Proiect { get; set; }

        public DateTime DataAtribuire { get; set; } = DateTime.Now;

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
