using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherApp.api;
using WeatherApp.entities;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private Api Api { get; } = new Api();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (int) Keys.Enter) return;
            
            var getCity = Api.GetCity(textBox1.Text);
            string key = getCity.Key;
        }
    }
}