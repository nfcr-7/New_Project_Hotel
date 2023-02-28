namespace Heron_Cendre.Models
{
    public class Evenement
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Nom_Evenement { get; set; }

        public DateTime Date_Debut_Evenement { get; set; }

        public DateTime Date_Fin_Evenement { get; set; }

        public float Prix { get; set; }

        public string Description { get; set; }

        public string Statut { get; set; }
    }
}
