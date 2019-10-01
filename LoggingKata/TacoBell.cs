using System;
using System.Collections.Generic;
using System.Text;
using GeoCoordinatePortable;

namespace LoggingKata
{
    public class TacoBell: ITrackable
    {
        public String Name { get; set; }
        public Point Locale { get; set; }
    }
}
