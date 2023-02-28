using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Reservation_Prestation
    {
        public int PrestaionId { get; set; }

        [ForeignKey("Prestation")]
        public Prestation Prestation { get; set; }

        public int ReservationId { get; set; }

        [ForeignKey("Reservation")]
        public Reservation Reservation { get; set; }
    }
}
