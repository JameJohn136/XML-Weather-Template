﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
       public static List<Day> days = new List<Day>();
        public static string location = "Stratford,CA";
        public static XmlReader reader;
        private CurrentScreen cs;

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static bool ExtractForecast()
        {
            // Clear Day List
            days.Clear();

            try
            {
                // TODO: Update URL to be for the city that is searched for
                reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={location}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

                while (reader.Read())
                {
                    //create a day object
                    Day d = new Day();

                    //fill day object with required data
                    reader.ReadToFollowing("time");
                    d.date = reader.GetAttribute("day");

                    reader.ReadToFollowing("sun");
                    d.sunRise = reader.GetAttribute("rise");
                    d.sunSet = reader.GetAttribute("set");

                    reader.ReadToFollowing("symbol");
                    d.condition = reader.GetAttribute("number");
                    d.condtionName = reader.GetAttribute("name");
                    d.iconID = reader.GetAttribute("var");

                    reader.ReadToFollowing("precipitation");
                    d.precipitationChance = reader.GetAttribute("probability");
                    d.precipitationName = reader.GetAttribute("name");
                    d.PrecipitationType = reader.GetAttribute("type");

                    reader.ReadToFollowing("windDirection");
                    d.windDirection = reader.GetAttribute("name");

                    reader.ReadToFollowing("windSpeed");
                    d.windSpeed = reader.GetAttribute("mps");
                    d.windUnit = reader.GetAttribute("unit");

                    reader.ReadToFollowing("temperature");
                    d.tempLow = reader.GetAttribute("min");
                    d.tempHigh = reader.GetAttribute("max");

                    reader.ReadToFollowing("humidity");
                    d.humidity = reader.GetAttribute("value");
                    d.humidityUnit = reader.GetAttribute("unit");

                    reader.ReadToFollowing("clouds");
                    d.clouds = reader.GetAttribute("value");

                    // Prevent adding null days
                    if (d.date != null) { days.Add(d); }

                }
                return true;
            }
            catch
            {
                return false;
            }

            
        }

        public static void ExtractCurrent()
        {

            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={location}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].tempLow = reader.GetAttribute("min");
            days[0].tempHigh = reader.GetAttribute("max");
            days[0].tempUnit = reader.GetAttribute("unit");

            // Last update time
            days[0].lastUpdateTime = DateTime.Now.ToString();

            // Change Format of Unit
            switch (days[0].tempUnit)
            {
                case "celsius":
                    days[0].tempUnit = "C";
                    break;
                case "fahrenheit":
                    days[0].tempUnit = "F";
                    break;
            }

        }
    }
}
