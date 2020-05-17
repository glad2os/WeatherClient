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
            // var file = File.ReadAllText(@"C:\Users\glad2os\RiderProjects\WeatherApp\bin\Debug\Moscow.json");
            // dynamic stuff = JsonConvert.DeserializeObject(file);
            // dynamic jopa = stuff[0];
            
            var getCity = Api.GetCity();
            string key = getCity.Key;
            
        }
    }
}