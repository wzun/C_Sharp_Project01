using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mybikes.bus
{
    [Serializable]
    public class Date
    {
        private int year;
        private int month;
        private int day;

        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }

        public Date()
        {
            year = 0000;
            month = 00;
            day = 00;
        }
        public Date(int year, int month, int day)
        {
            this.year = 0000;
            this.month = 00;
            this.day = 00;
        }

        public override string ToString()
        {
            return year + "/" + month + "/" + day;
        }
    }
}

