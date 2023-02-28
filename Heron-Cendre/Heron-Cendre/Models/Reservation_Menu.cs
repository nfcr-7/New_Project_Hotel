using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Reservation_Menu
    {
        public int MenuId { get; set; }

        [ForeignKey("Menu")]
        public Menu Menu { get; set; }

        public int ReservationId { get; set; }

        [ForeignKey("Reservation")]
        public Reservation Reservation { get; set; }
    }
}
