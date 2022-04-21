using System;
using System.Collections.Generic;
using System.Text;

namespace EnqueteSPA.Entities
{
    public class Visite
    {
        public virtual int ID { get; set; }
        public virtual Personne enqueteur { get; set; }
        public virtual int numAvisPassage{ get; set; }
        public virtual String commentaires{ get; set; }
        public virtual Enquete enquete { get; set; }

    }
}
