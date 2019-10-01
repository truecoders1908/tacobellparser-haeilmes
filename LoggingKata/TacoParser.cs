using System;
using System.Collections.Generic;
using GeoCoordinatePortable;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            var cells = line.Split(',');

            if(cells.Length<3)
            {
                logger.LogInfo("The number of items is too few.");
                return null;
            }

            double longtitude = Convert.ToDouble(cells[0]);
            double latitude = Convert.ToDouble(cells[1]);
            string name = cells[2];

            TacoBell tacoBell = new TacoBell();

            tacoBell.Name = name;

            Point point = new Point();
            point.Longitude = longtitude;
            point.Latitude = latitude;

            tacoBell.Locale = point;

            return tacoBell;
        }
    }
}