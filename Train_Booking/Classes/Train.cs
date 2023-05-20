using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBooking.Classes
{
    public class Train
    {
        public int train_id;
        public int total_seats;

        public Train(int total_seats)
        {
            this.total_seats = total_seats;
        }

        public override string ToString()
        {
            return $"{train_id} | {total_seats}";
        }
    }
}
