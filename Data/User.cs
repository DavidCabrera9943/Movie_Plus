using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class User : BaseEntity
    {
        public string Name_User { get; set; }
        public string Email { get; set; }
        public int Discount { get; set; }
        public int Card { get; set; }


        public ICollection<Buys_Ticket> BuysTicket { get; set; }

    }
}
