using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Buys_Ticket : BaseEntity
    {
        public int NumberTickets { get; set; }
        public DateTime DateTime { get; set; }
        public string Voucher { get; set; }



        public int MovieId { get; set; }
        public int UserId { get; set; }
        public virtual Movie Movies { get; set; }
        public virtual User User { get; set; }


    }


}
