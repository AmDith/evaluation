namespace WebApplication2.Models
{
    public class InscriptionEtudiant
    {
        public int _Id { get; set; }
        public string _anneeScolaire { get; set; }
        public static int nbreIE { get; set; }
        public Etudiant etudiant { get; set; }
        public Inscription Inscription { get; set; }
        public InscriptionEtudiant()
        {
            _Id = ++nbreIE;
        }
    }
}
