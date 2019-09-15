using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybikes.bus
{
    public enum EnumColor
    {
        undefined, red, blue, green, yellow
    }
    public enum EnumWheel
    {
        undefined, small_wheel, middle_wheel, large_wheel, exlarge_wheel
    }
    public enum EnumSpeed
    {
        undefined, speed1, speed2, speed3, speed4
    }

    [Serializable]
    public abstract class Bikes : IBikes
    {
        private int serialNumber;
        private string band;
        private string model;
        private int weight;
        private EnumColor color;
        private EnumWheel wheel;
        private EnumSpeed speed;
        private Date madeDate;

        public int SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Band { get => band; set => band = value; }
        public string Model { get => model; set => model = value; }
        public int Weight { get => weight; set => weight = value; }
        public EnumColor Color { get => color; set => color = value; }
        public EnumWheel Wheel { get => wheel; set => wheel = value; }
        public EnumSpeed Speed { get => speed; set => speed = value; }
        public Date MadeDate { get => madeDate; set => madeDate = value; }

        public Bikes()
        {
            this.serialNumber = 0000;
            this.band = "Undefined";
            this.model = "Undefined";
            this.weight = 0000;
            this.color = EnumColor.undefined;
            this.wheel = EnumWheel.undefined;
            this.speed = EnumSpeed.undefined;
            this.madeDate = new Date();
        }

        public Bikes(int serialNumber, string band, string model, int weight,
                    EnumColor color, EnumWheel wheel, EnumSpeed speed, Date madeDate)
        {
            this.serialNumber = serialNumber;
            this.band = band;
            this.model = model;
            this.weight = weight;
            this.color = color;
            this.wheel = wheel;
            this.speed = speed;
            this.madeDate = madeDate;
        }

        public override string ToString()
        {
            return serialNumber + "\t    " + band + "\t   " + model + "\t    " + weight + "\t   "
                      + color + "\t     " + wheel + "  \t  " + speed + "\t   " + madeDate;
        }
        public abstract string Start();
        public abstract string Stop();
        public abstract string Accelerate();
        public abstract string Brake();
    }
}
