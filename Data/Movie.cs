using System;
using System.Collections;
using System.Collections.Generic;


namespace Data
{
    public class Movie : BaseEntity
    {
        public string Name_Movie { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }
        public List<string> Actors { get; set; }
        public string Genre { get; set; }
        public int Ranting { get; set; }
        public bool Foreign { get; set; }



        public virtual IEnumerable<Local_Movie> LocalMovie { get; set; }
        public virtual ICollection<Buys_Ticket> BuysTicket { get; set; }

    }
}
