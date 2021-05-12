using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Local_Movie : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }


        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

    }
}
