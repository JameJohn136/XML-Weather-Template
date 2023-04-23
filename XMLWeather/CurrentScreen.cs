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
            DisplayForecast();
            ChangeBackground();

            // Set initial city
            cityInput.Text = Form1.location;
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            todayLabel.Text = $"Today: {Form1.days[0].date}";

            tempLabel.Text = $"Current: {Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0)}°{Form1.days[0].tempUnit}";
            currentMaxLabel.Text = $"Max: {Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0)}°{Form1.days[0].tempUnit}";
            currentMinLabel.Text = $"Min: {Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0)}°{Form1.days[0].tempUnit}";
            currentConditonLabel.Text = $"Conditon: {Form1.days[0].condtionName}";

            lastUpdateTime.Text = $"Last Update: {Form1.days[0].lastUpdateTime}";

            humidityText.Text = $"Humidity: {Form1.days[0].humidity}{Form1.days[0].humidityUnit}";

            sunLabel.Text = $"Sun Rise: {Form1.days[0].sunRise}\nSun Set: {Form1.days[0].sunSet}";

            // Display current weather icon
            string url = $"https://openweathermap.org/img/wn/{Form1.days[0].iconID}@2x.png";
            weatherIcon.LoadAsync(url);
        }

        public void DisplayForecast()
        {
            foreach (Control control in this.Controls)
            {
                Label b = control as Label;
                if (b != null)
                {
                    if (b.Name.Contains("dateLabel"))
                    {
                        int x = Convert.ToInt32(b.Name.Last().ToString());
                        b.Text = $"Date: {Form1.days[x].date}";
                    }

                    if (b.Name.Contains("minLabel"))
                    {
                        int x = Convert.ToInt32(b.Name.Last().ToString());
                        b.Text = $"Min: {Form1.days[x].tempLow}{Form1.days[x].tempUnit}";
                    }

                    if (b.Name.Contains("maxLabel"))
                    {
                        int x = Convert.ToInt32(b.Name.Last().ToString());
                        b.Text = $"Max: {Form1.days[x].tempHigh}{Form1.days[x].tempUnit}";
                    }

                    if (b.Name.Contains("conditionLabel"))
                    {
                        int x = Convert.ToInt32(b.Name.Last().ToString());
                        b.Text = $"Condition: {Form1.days[x].condtionName}";
                    }

                }

                PictureBox p = control as PictureBox;
                if (p != null)
                {
                    if (p.Name.Contains("pictureBox"))
                    {
                        int x = Convert.ToInt32(p.Name.Last().ToString());
                        p.LoadAsync($"https://openweathermap.org/img/wn/{Form1.days[x].iconID}@2x.png");
                    }
                }
            }
        }

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
                this.BackColor = Color.CadetBlue;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form1.location = cityInput.Text;
            if (Form1.ExtractForecast())
            {
                Form1.ExtractCurrent();
                DisplayCurrent();
                DisplayForecast();
                ChangeBackground();
            }
            else
            {
                cityInput.Text = "Invalid Input";
            }
        }

    }
}
