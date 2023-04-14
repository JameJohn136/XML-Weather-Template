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
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            currentDateLabel.Text = Form1.days[0].date;
            currentOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0).ToString()}°{Form1.days[0].tempUnit}";
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        public void ChangeBackground()
        {
            int x = Convert.ToInt32(Form1.days[0].condition);
            if (x == 800) // Clear
            {
                
            } else if (801 <= x && x <= 804) // Clouds
            {

            }





        }
    }
}
