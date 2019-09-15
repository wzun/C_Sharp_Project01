using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybikes.bus
{
    [Serializable]
    public class RoadBikes :Bikes
    {
        private int seatHight;

        public int SeatHight { get => seatHight; set => seatHight = value; }


        public RoadBikes() : base()
        {
            this.seatHight = 0000;
        }

        public RoadBikes(int serialNumber, string band, string model, int weight,
                             EnumColor color, EnumWheel wheel, EnumSpeed speed, Date madeDate,
                             int seatHight)
                             : base(serialNumber, band, model, weight, color, wheel, speed, madeDate)
        {
            this.seatHight = seatHight;
        }

        public override string ToString()
        {
            return base.ToString() + "\t   " + seatHight ;
        }

        public override string Start()
        {
            return "RoadBike now start to ride.";

        }
        public override string Stop()
        {
            return "RoadBike now stop.";

        }
        public override string Accelerate()
        {
            return "RoadBike now start to accelerate.";

        }
        public override string Brake()
        {
            return "RoadBike now brake to slow.";

        }
    }
}
