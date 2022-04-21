using System;
using System.Collections.Generic;
using System.Text;

namespace EnqueteSPA.Entities
{
    // etat(id, etat)
    public class Etat
    {
        public virtual int ID { get; set; }
        public virtual String etat { get; set; }
    }
}
