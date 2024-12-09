namespace WebApplication2.Models
{
    public class Inscription
    {
        public int _Id { get; set; }
        public string _annee { get; set; }
        public string _semestre { get; set; }
        public static int nbreI { get; set; }
        public List<InscriptionEtudiant> inscriptionEtudiants { get; }
        public Inscription()
        {
            _Id = ++nbreI;
            inscriptionEtudiants = new List<InscriptionEtudiant>();
        }

        public void addInscriptionEtudiant(InscriptionEtudiant inscription)
        {
            inscriptionEtudiants.Add(inscription);
        }
    }
}
