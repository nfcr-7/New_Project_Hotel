using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Chambre
    {
        [Key]

        public int Id { get; set; }

        public int Num_Chambre { get; set; }

        public string Image_Chambre { get; set; }

        public string Categorie { get; set; }

        public float Prix { get; set; }

        public string Description { get; set; }

        public int ReservationId { get; set; }

        [ForeignKey("Reservation")]
        public Reservation Reservation { get; set; }

        public string statut { get; set; }

        public List<Reservation_Chambre> Reservations_Chambres { get; set; }
    }
}
