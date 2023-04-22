using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
            ChangeBackground();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            currentDateLabel.Text = Form1.days[0].date;

            tempLabel.Text = $"Current: {Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0)}°{Form1.days[0].tempUnit}";
            maxLabel.Text = $"Max: {Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0)}°{Form1.days[0].tempUnit}";
            minLabel.Text = $"Min: {Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0)}°{Form1.days[0].tempUnit}";
            currentConditonLabel.Text = $"Conditon: {Form1.days[0].condtionName}";

            lastUpdateTime.Text = $"Last Update: {Form1.days[0].lastUpdateTime}";

            humidityText.Text = $"Humidity: {Form1.days[0].humidity}{Form1.days[0].humidityUnit}";

            sunLabel.Text = $"Sun Rise: {Form1.days[0].sunRise}\nSun Set: {Form1.days[0].sunSet}";

            // Display current weather icon
            string url = $"https://openweathermap.org/img/wn/{Form1.days[0].iconID}@2x.png";
            weatherIcon.LoadAsync(url);
        }

        //private void forecastLabel_Click(object sender, EventArgs e)
        //{
        //    Form f = this.FindForm();
        //    f.Controls.Remove(this);

        //    ForecastScreen fs = new ForecastScreen();
        //    f.Controls.Add(fs);
        //}

        public void ChangeBackground()
        {
            int x = Convert.ToInt32(Form1.days[0].condition);
            if (x >= 200 && x <= 232) // ThunderStorm
            {
                this.BackColor = Color.DarkGray;
            } 
            else if (x >= 300 && x <= 321) // Drizzle
            {
                this.BackColor = Color.LightBlue;
            }
            else if (x >= 500 && x <= 531) // Rain
            {
                this.BackColor = Color.DarkSlateBlue;
            }
            else if (x >= 600 && x <= 622) // Snow
            {
                this.BackColor = Color.LightGray;
            }
            else if (x >= 701 && x <= 781) // Atmosphere (Sand, Tornado etc)
            {
                this.BackColor = Color.DimGray;
            }
            else if (x == 800) // Clear
            {
                this.BackColor = Color.LightSkyBlue;
            } 
            else if (801 <= x && x <= 804) // Clouds
            {
                this.BackColor = Color.LightSlateGray;
            }





        }
    }
}
