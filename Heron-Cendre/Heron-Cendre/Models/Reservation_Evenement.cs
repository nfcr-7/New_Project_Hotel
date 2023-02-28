using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Reservation_Evenement
    {
        public int EvenementId { get; set; }

        [ForeignKey("Evenement")]
        public Evenement Evenement { get; set; }


        public int ReservationId { get; set; }

        [ForeignKey("Reservation")]
        public Reservation Reservation { get; set; }


    }
}
