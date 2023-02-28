namespace Heron_Cendre.Models
{
    public class Prestation
    {
        public int Id { get; set; }

        public string Nom_Service { get; set; }

        public string Description { get; set; }

        public DateTime Date_Debut { get; set; }

        public DateTime Date_Fin { get; set; }

        public float Prix { get; set; }

        public string Statut { get; set; }
    }
}
