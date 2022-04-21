using System;
using System.Collections.Generic;
using System.Text;

namespace EnqueteSPA.Entities
{
    public class Location
    {
        public virtual int ID { get; set; }
        public virtual string Street { get; set; }
        public virtual string City { get; set; }
        public virtual string Province { get; set; }
        public virtual string Country { get; set; }

        public override string ToString() {
            return Street + " " + City + " " + Province + " " + Country;
        }

        public static implicit operator string(Location v)
        {
            if (v != null)
                return v.ToString();
            else return "";
        }
    }
}
