using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybikes.bus
{
    public enum EnumSuspension
        {
            undefined,front, rear, front_and_rear
        };

    [Serializable]
    public class MountainBikes :Bikes
    {

        private int height_from_ground;
        private EnumSuspension suspension;

        public int Height_from_ground { get => height_from_ground; set => height_from_ground = value; }
        public EnumSuspension Suspension { get => suspension; set => suspension = value; }

        public MountainBikes() :base()
        {
            this.height_from_ground = 0000;
            this.suspension = EnumSuspension.undefined;
        }

        public MountainBikes(int serialNumber, string band, string model, int weight,
                             EnumColor color, EnumWheel wheel, EnumSpeed speed, Date madeDate, 
                             int height_from_ground, EnumSuspension suspension) 
                             :base(serialNumber, band, model, weight, color, wheel, speed, madeDate)
        {
            this.height_from_ground = height_from_ground;
            this.suspension = suspension;
        }

        public override string ToString()
        {
            return  base.ToString() + "\t   " + height_from_ground + "\t   " + suspension ;
        }
        public override string Start()
        {
            return "MountainBike now start to ride.";

        }
        public override string Stop()
        {
            return "MountainBike now stop.";

        }
        public override string Accelerate()
        {
            return "MountainBike now start to accelerate.";

        }
        public override string Brake()
        {
            return "MountainBike now brake to slow.";

        }
    }
}
