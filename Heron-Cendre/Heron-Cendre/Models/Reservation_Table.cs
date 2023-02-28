using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Reservation_Table
    {
        public int TableId { get; set; }

        [ForeignKey("Table")]
        public Table Table { get; set; }

        public int ReservationId { get; set; }

        [ForeignKey("Reservation")]
        public Reservation Reservation { get; set; }
    }
}
