namespace WebApplication2.Models
{
    public class Absence
    {
        public int _Id { get; set; }
        public int _NbreHAbsence { get; set; }
        public static int nbreA { get; set; }
        public Etudiant Etudiant { get; set; }
        public Cours Cours { get; set; }
        public Absence()
        {
            _Id = ++nbreA;
        }

    }
}
