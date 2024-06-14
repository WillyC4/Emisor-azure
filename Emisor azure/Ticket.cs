using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptor_Azure
{
    public class Ticket
    {
        public string TicketId { get; set; }
        public string AlarmEventId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }

}
