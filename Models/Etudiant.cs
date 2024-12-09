using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Etudiant
    {
        public int _Id { get; set; }
        public int _Mat { get; set; }
        public string _NomComplet { get; set; }
        
        public string _Adresse { get; set; }

        public static int nbreE {  get; set; }
        public List<InscriptionEtudiant> inscriptionEtudiants { get; }
        public List<Absence> absences { get; }
        public List<Cours> Lcours { get; }
        public Etudiant() { 
            _Id = ++ nbreE;
        }
        public void addInscriptionEtudiant(InscriptionEtudiant inscription)
        {
            inscriptionEtudiants.Add(inscription);
        }
        public void addAbsence(Absence absence)
        {
            absences.Add(absence);
        }
        public void addCours(Cours cours)
        {
            Lcours.Add(cours);
        }
    }
}
