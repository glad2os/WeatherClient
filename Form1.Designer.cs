namespace WeatherApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.currentPicture = new System.Windows.Forms.PictureBox();
            this.currentTempLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentRealFeelTemperatureLabel = new System.Windows.Forms.Label();
            this.currentRealFeelTemperatureShadeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nightPicture = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.DailyTempLabel = new System.Windows.Forms.Label();
            this.dayPicture = new System.Windows.Forms.PictureBox();
            this.label29 = new System.Windows.Forms.Label();
            this.UVIndexLabel = new System.Windows.Forms.Label();
            this.WindLabel = new System.Windows.Forms.Label();
            this.WindGustLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.DewPointLabel = new System.Windows.Forms.Label();
            this.RelativeHumidityLabel = new System.Windows.Forms.Label();
            this.CeilingLabel = new System.Windows.Forms.Label();
            this.VisibilityLabel = new System.Windows.Forms.Label();
            this.CloudCoverLabel = new System.Windows.Forms.Label();
            this.dayStatusLabel = new System.Windows.Forms.Label();
            this.nightStatusLabel = new System.Windows.Forms.Label();
            this.currentWeatherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.currentPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nightPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dayPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Астрахань";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущая погода";
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(12, 79);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(34, 13);
            this.currentTimeLabel.TabIndex = 2;
            this.currentTimeLabel.Text = "00:00";
            // 
            // currentPicture
            // 
            this.currentPicture.Image = ((System.Drawing.Image) (resources.GetObject("currentPicture.Image")));
            this.currentPicture.Location = new System.Drawing.Point(12, 95);
            this.currentPicture.Name = "currentPicture";
            this.currentPicture.Size = new System.Drawing.Size(100, 50);
            this.currentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.currentPicture.TabIndex = 3;
            this.currentPicture.TabStop = false;
            // 
            // currentTempLabel
            // 
            this.currentTempLabel.AutoSize = true;
            this.currentTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.currentTempLabel.Location = new System.Drawing.Point(118, 79);
            this.currentTempLabel.Name = "currentTempLabel";
            this.currentTempLabel.Size = new System.Drawing.Size(32, 25);
            this.currentTempLabel.TabIndex = 4;
            this.currentTempLabel.Text = "0°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ощущается как";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ощущается в тени";
            // 
            // currentRealFeelTemperatureLabel
            // 
            this.currentRealFeelTemperatureLabel.AutoSize = true;
            this.currentRealFeelTemperatureLabel.Location = new System.Drawing.Point(226, 113);
            this.currentRealFeelTemperatureLabel.Name = "currentRealFeelTemperatureLabel";
            this.currentRealFeelTemperatureLabel.Size = new System.Drawing.Size(35, 13);
            this.currentRealFeelTemperatureLabel.TabIndex = 5;
            this.currentRealFeelTemperatureLabel.Text = "label6";
            // 
            // currentRealFeelTemperatureShadeLabel
            // 
            this.currentRealFeelTemperatureShadeLabel.AutoSize = true;
            this.currentRealFeelTemperatureShadeLabel.Location = new System.Drawing.Point(226, 132);
            this.currentRealFeelTemperatureShadeLabel.Name = "currentRealFeelTemperatureShadeLabel";
            this.currentRealFeelTemperatureShadeLabel.Size = new System.Drawing.Size(35, 13);
            this.currentRealFeelTemperatureShadeLabel.TabIndex = 5;
            this.currentRealFeelTemperatureShadeLabel.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "УФ-Индекс";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(311, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ветер";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Порывы";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Влажность";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(311, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Точка росы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Давление";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(311, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Облачность";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(311, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Видимость";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(311, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Предел";
            // 
            // nightPicture
            // 
            this.nightPicture.Image = ((System.Drawing.Image) (resources.GetObject("nightPicture.Image")));
            this.nightPicture.Location = new System.Drawing.Point(311, 234);
            this.nightPicture.Name = "nightPicture";
            this.nightPicture.Size = new System.Drawing.Size(100, 50);
            this.nightPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nightPicture.TabIndex = 17;
            this.nightPicture.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(311, 218);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Ночь";
            // 
            // DailyTempLabel
            // 
            this.DailyTempLabel.AutoSize = true;
            this.DailyTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.DailyTempLabel.Location = new System.Drawing.Point(119, 216);
            this.DailyTempLabel.Name = "DailyTempLabel";
            this.DailyTempLabel.Size = new System.Drawing.Size(32, 25);
            this.DailyTempLabel.TabIndex = 28;
            this.DailyTempLabel.Text = "0°";
            // 
            // dayPicture
            // 
            this.dayPicture.Image = ((System.Drawing.Image) (resources.GetObject("dayPicture.Image")));
            this.dayPicture.Location = new System.Drawing.Point(13, 232);
            this.dayPicture.Name = "dayPicture";
            this.dayPicture.Size = new System.Drawing.Size(100, 50);
            this.dayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dayPicture.TabIndex = 25;
            this.dayPicture.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 216);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 13);
            this.label29.TabIndex = 24;
            this.label29.Text = "День";
            // 
            // UVIndexLabel
            // 
            this.UVIndexLabel.AutoSize = true;
            this.UVIndexLabel.Location = new System.Drawing.Point(384, 53);
            this.UVIndexLabel.Name = "UVIndexLabel";
            this.UVIndexLabel.Size = new System.Drawing.Size(41, 13);
            this.UVIndexLabel.TabIndex = 31;
            this.UVIndexLabel.Text = "label31";
            // 
            // WindLabel
            // 
            this.WindLabel.AutoSize = true;
            this.WindLabel.Location = new System.Drawing.Point(384, 68);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(13, 13);
            this.WindLabel.TabIndex = 31;
            this.WindLabel.Text = "0";
            // 
            // WindGustLabel
            // 
            this.WindGustLabel.AutoSize = true;
            this.WindGustLabel.Location = new System.Drawing.Point(384, 83);
            this.WindGustLabel.Name = "WindGustLabel";
            this.WindGustLabel.Size = new System.Drawing.Size(13, 13);
            this.WindGustLabel.TabIndex = 31;
            this.WindGustLabel.Text = "0";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Location = new System.Drawing.Point(384, 128);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(41, 13);
            this.PressureLabel.TabIndex = 32;
            this.PressureLabel.Text = "label31";
            // 
            // DewPointLabel
            // 
            this.DewPointLabel.AutoSize = true;
            this.DewPointLabel.Location = new System.Drawing.Point(384, 113);
            this.DewPointLabel.Name = "DewPointLabel";
            this.DewPointLabel.Size = new System.Drawing.Size(41, 13);
            this.DewPointLabel.TabIndex = 33;
            this.DewPointLabel.Text = "label31";
            // 
            // RelativeHumidityLabel
            // 
            this.RelativeHumidityLabel.AutoSize = true;
            this.RelativeHumidityLabel.Location = new System.Drawing.Point(384, 98);
            this.RelativeHumidityLabel.Name = "RelativeHumidityLabel";
            this.RelativeHumidityLabel.Size = new System.Drawing.Size(41, 13);
            this.RelativeHumidityLabel.TabIndex = 34;
            this.RelativeHumidityLabel.Text = "label36";
            // 
            // CeilingLabel
            // 
            this.CeilingLabel.AutoSize = true;
            this.CeilingLabel.Location = new System.Drawing.Point(384, 173);
            this.CeilingLabel.Name = "CeilingLabel";
            this.CeilingLabel.Size = new System.Drawing.Size(41, 13);
            this.CeilingLabel.TabIndex = 35;
            this.CeilingLabel.Text = "label31";
            // 
            // VisibilityLabel
            // 
            this.VisibilityLabel.AutoSize = true;
            this.VisibilityLabel.Location = new System.Drawing.Point(384, 158);
            this.VisibilityLabel.Name = "VisibilityLabel";
            this.VisibilityLabel.Size = new System.Drawing.Size(41, 13);
            this.VisibilityLabel.TabIndex = 36;
            this.VisibilityLabel.Text = "label31";
            // 
            // CloudCoverLabel
            // 
            this.CloudCoverLabel.AutoSize = true;
            this.CloudCoverLabel.Location = new System.Drawing.Point(384, 143);
            this.CloudCoverLabel.Name = "CloudCoverLabel";
            this.CloudCoverLabel.Size = new System.Drawing.Size(41, 13);
            this.CloudCoverLabel.TabIndex = 37;
            this.CloudCoverLabel.Text = "label39";
            // 
            // dayStatusLabel
            // 
            this.dayStatusLabel.AutoSize = true;
            this.dayStatusLabel.Location = new System.Drawing.Point(119, 241);
            this.dayStatusLabel.Name = "dayStatusLabel";
            this.dayStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.dayStatusLabel.TabIndex = 38;
            this.dayStatusLabel.Text = "status";
            // 
            // nightStatusLabel
            // 
            this.nightStatusLabel.AutoSize = true;
            this.nightStatusLabel.Location = new System.Drawing.Point(417, 241);
            this.nightStatusLabel.Name = "nightStatusLabel";
            this.nightStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.nightStatusLabel.TabIndex = 39;
            this.nightStatusLabel.Text = "status";
            // 
            // currentWeatherLabel
            // 
            this.currentWeatherLabel.AutoSize = true;
            this.currentWeatherLabel.Location = new System.Drawing.Point(12, 148);
            this.currentWeatherLabel.Name = "currentWeatherLabel";
            this.currentWeatherLabel.Size = new System.Drawing.Size(35, 13);
            this.currentWeatherLabel.TabIndex = 42;
            this.currentWeatherLabel.Text = "status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(622, 293);
            this.Controls.Add(this.currentWeatherLabel);
            this.Controls.Add(this.nightStatusLabel);
            this.Controls.Add(this.dayStatusLabel);
            this.Controls.Add(this.CeilingLabel);
            this.Controls.Add(this.VisibilityLabel);
            this.Controls.Add(this.CloudCoverLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.DewPointLabel);
            this.Controls.Add(this.RelativeHumidityLabel);
            this.Controls.Add(this.WindGustLabel);
            this.Controls.Add(this.WindLabel);
            this.Controls.Add(this.UVIndexLabel);
            this.Controls.Add(this.DailyTempLabel);
            this.Controls.Add(this.dayPicture);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.nightPicture);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.currentRealFeelTemperatureShadeLabel);
            this.Controls.Add(this.currentRealFeelTemperatureLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currentTempLabel);
            this.Controls.Add(this.currentPicture);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccuWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.currentPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nightPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dayPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label CeilingLabel;
        private System.Windows.Forms.Label CloudCoverLabel;
        private System.Windows.Forms.PictureBox currentPicture;
        private System.Windows.Forms.Label currentRealFeelTemperatureLabel;
        private System.Windows.Forms.Label currentRealFeelTemperatureShadeLabel;
        private System.Windows.Forms.Label currentTempLabel;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label currentWeatherLabel;
        private System.Windows.Forms.Label DailyTempLabel;
        private System.Windows.Forms.PictureBox dayPicture;
        private System.Windows.Forms.Label dayStatusLabel;
        private System.Windows.Forms.Label DewPointLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox nightPicture;
        private System.Windows.Forms.Label nightStatusLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label RelativeHumidityLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label UVIndexLabel;
        private System.Windows.Forms.Label VisibilityLabel;
        private System.Windows.Forms.Label WindGustLabel;
        private System.Windows.Forms.Label WindLabel;

        #endregion
    }
}