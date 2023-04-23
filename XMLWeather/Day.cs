using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, condtionName, location, tempHigh, tempLow,
            windSpeed, windDirection, precipitationChance, precipitationName, PrecipitationType, visibility, tempUnit, humidity, humidityUnit, clouds, sunRise, sunSet, lastUpdateTime, iconID, windUnit;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitationChance = visibility = tempUnit = precipitationName = PrecipitationType = condtionName = humidity =  humidityUnit = clouds = sunRise = sunSet = lastUpdateTime = iconID = windUnit = "";
        }
    }
}
