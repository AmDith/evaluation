namespace WebApplication2.Models
{
    public class Cours
    {
        public int _Id { get; set; }
        public DateOnly _Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public DateTime _Hdebut {  get; set; } = DateTime.Now;
        public DateTime _Hfin { get; set;} = DateTime.Now;
        public int _NbreH { get; set; }
        public string _semestre { get; set; }
        public static int nbreC { get; set; }
        public List<Absence> absences { get; }
        public Cours()
        {
            _Id = ++nbreC;
        }
        public void addAbsence(Absence absence)
        {
            absences.Add(absence);
        }

    }
}
