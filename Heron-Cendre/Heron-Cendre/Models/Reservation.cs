using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public DateTime Date_Debut { get; set; }

        public DateTime Date_Fin { get; set; }

        public string Mode_Reservation { get; set; }

        public string Categorie { get; set; }

        public int Quantite { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("Client")]
        public Client Client { get; set; }

        public List<Reservation_Chambre> Reservations_Chambres { get; set; }

    }
}
