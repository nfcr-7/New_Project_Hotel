using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Reservation_Chambre
    {
        public int ChambreId { get; set; }

        [ForeignKey("Chambre")]
        public Chambre Chambre { get; set; }

        public int ReservationId { get; set; }

        [ForeignKey("Reservation")]
        public Reservation Reservation { get; set; }
    } 
}
