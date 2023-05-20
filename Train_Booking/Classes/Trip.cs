using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Train_Booking.Classes {
    public class Trip {
        public int trip_id { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public int train_id { get; set; }
        public string tripDate { get; set; }
        public double price { get; set; }

        public Trip(){}

        public override string ToString() {
            return $"{source} | {destination} | {price} | {train_id}";
        }
    }
}