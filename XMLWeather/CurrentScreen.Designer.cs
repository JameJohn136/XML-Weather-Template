namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.currentConditonLabel = new System.Windows.Forms.Label();
            this.lastUpdateTime = new System.Windows.Forms.Label();
            this.humidityText = new System.Windows.Forms.Label();
            this.sunLabel = new System.Windows.Forms.Label();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(127, 73);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(38, 19);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(21, 180);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(41, 19);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(21, 158);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(36, 19);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(21, 136);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(168, 19);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(127, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentDateLabel.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.ForeColor = System.Drawing.Color.White;
            this.currentDateLabel.Location = new System.Drawing.Point(127, 43);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(45, 19);
            this.currentDateLabel.TabIndex = 43;
            this.currentDateLabel.Text = "Date";
            // 
            // currentConditonLabel
            // 
            this.currentConditonLabel.AutoSize = true;
            this.currentConditonLabel.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentConditonLabel.ForeColor = System.Drawing.Color.White;
            this.currentConditonLabel.Location = new System.Drawing.Point(23, 233);
            this.currentConditonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentConditonLabel.Name = "currentConditonLabel";
            this.currentConditonLabel.Size = new System.Drawing.Size(84, 19);
            this.currentConditonLabel.TabIndex = 44;
            this.currentConditonLabel.Text = "Condition:";
            // 
            // lastUpdateTime
            // 
            this.lastUpdateTime.AutoSize = true;
            this.lastUpdateTime.BackColor = System.Drawing.Color.Transparent;
            this.lastUpdateTime.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdateTime.ForeColor = System.Drawing.Color.White;
            this.lastUpdateTime.Location = new System.Drawing.Point(6, 381);
            this.lastUpdateTime.Name = "lastUpdateTime";
            this.lastUpdateTime.Size = new System.Drawing.Size(101, 19);
            this.lastUpdateTime.TabIndex = 45;
            this.lastUpdateTime.Text = "Last Update";
            // 
            // humidityText
            // 
            this.humidityText.AutoSize = true;
            this.humidityText.BackColor = System.Drawing.Color.Transparent;
            this.humidityText.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityText.ForeColor = System.Drawing.Color.White;
            this.humidityText.Location = new System.Drawing.Point(21, 320);
            this.humidityText.Name = "humidityText";
            this.humidityText.Size = new System.Drawing.Size(76, 19);
            this.humidityText.TabIndex = 46;
            this.humidityText.Text = "Humidity";
            // 
            // sunLabel
            // 
            this.sunLabel.AutoSize = true;
            this.sunLabel.BackColor = System.Drawing.Color.Transparent;
            this.sunLabel.Font = new System.Drawing.Font("Nexa-Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunLabel.ForeColor = System.Drawing.Color.White;
            this.sunLabel.Location = new System.Drawing.Point(21, 280);
            this.sunLabel.Name = "sunLabel";
            this.sunLabel.Size = new System.Drawing.Size(134, 19);
            this.sunLabel.TabIndex = 47;
            this.sunLabel.Text = "Sun Rise and Set";
            // 
            // weatherIcon
            // 
            this.weatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.weatherIcon.Location = new System.Drawing.Point(10, 9);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(97, 87);
            this.weatherIcon.TabIndex = 48;
            this.weatherIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "_______________________";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.sunLabel);
            this.Controls.Add(this.humidityText);
            this.Controls.Add(this.lastUpdateTime);
            this.Controls.Add(this.currentConditonLabel);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.tempLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(500, 400);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Label currentConditonLabel;
        private System.Windows.Forms.Label lastUpdateTime;
        private System.Windows.Forms.Label humidityText;
        private System.Windows.Forms.Label sunLabel;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Label label1;
    }
}
