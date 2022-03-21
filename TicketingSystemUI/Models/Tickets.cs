using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystemUI.Models
{
    public class Tickets
    {
        [Key]
        public int ticketID { get; set; }
        public int status_id { get; set; }
        public int pid { get; set; }
        public string uid { get; set; }
        public string title { get; set; }
        public string uemailPrefix { get; set; }
        public string tDescriptions { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

    }
}
