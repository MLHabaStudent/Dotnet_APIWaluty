using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWaluty
{
    public partial class Form1 : Form
    {
        DataManager dataManager = new DataManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void setText(string data)
        {
            listBox1.Items.Add(data);
        }

        private async void updateData()
        {
            Currency recieved;
            HttpClient client = new HttpClient();

            DateTime date = calendar.SelectionRange.Start;
            int day, month, year;
            day = date.Day;
            month = date.Month;
            year = date.Year;
            string s_day, s_month;

            if (day < 10) s_day = "0" + day.ToString();
            else s_day = day.ToString();

            if (month < 10) s_month = "0" + month.ToString();
            else s_month = month.ToString();


            string request = "https://openexchangerates.org/api/historical/" + year + "-" + s_month + "-" + s_day + ".json?app_id=8fd494470bca455a8caf0d3d918a97fb";
            string response = await client.GetStringAsync(request);
            recieved = JsonConvert.DeserializeObject<Currency>(response);

            setText(recieved.ToString());
        }
    }
}
