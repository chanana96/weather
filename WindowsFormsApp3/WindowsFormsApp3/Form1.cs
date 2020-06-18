using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city;
            city = txtcity.Text;

            string uri = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&mode=xml&units=metric&appid=78dff84492be32f8b4f77692904607a1", city);

            XDocument doc = XDocument.Load(uri);

            string iconUri = (string)doc.Descendants("weather").FirstOrDefault().Attribute("icon").Value;


            WebClient client = new WebClient();

            byte[] image = client.DownloadData("http://openweathermap.org/img/wn/" + iconUri + "@2x.png");

            MemoryStream stream = new MemoryStream(image);


            Bitmap newBitMap = new Bitmap(stream);

            string maxTemp = (string)doc.Descendants("temperature").FirstOrDefault().Attribute("max").Value;
            string minTemp = (string)doc.Descendants("temperature").FirstOrDefault().Attribute("min").Value;

            string maxWindm = (string)doc.Descendants("speed").FirstOrDefault().Attribute("value").Value;
            string windDirection = (string)doc.Descendants("direction").FirstOrDefault().Attribute("name").Value;
            string humidity = (string)doc.Descendants("humidity").FirstOrDefault().Attribute("value").Value;

            string country = (string)doc.Descendants("country").FirstOrDefault();

            Bitmap icon = newBitMap;

            txtmaxtemp.Text = maxTemp;
            txtmintemp.Text = minTemp;

            txtwindm.Text = maxWindm;
            txtwinddirection.Text = windDirection;
            txthumidity.Text = humidity;

            txtcountry.Text = country;
            pictureBox1.Image = icon;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
