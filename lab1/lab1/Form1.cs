using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace lab1
{
    public partial class Form1 : Form
    {
        Rate[] rates;

        public Form1()
        {
            InitializeComponent();
            GetJsonDoc();
        }

        public void GetJsonDoc()
        {
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("http://www.nbrb.by/API/ExRates/Rates?Periodicity=0");
            httpRequest.Method = "GET";
            httpRequest.ContentType = "text/json";
            httpRequest.KeepAlive = true;
            HttpWebResponse resp = (HttpWebResponse)httpRequest.GetResponse();
            string result = "";
            using (StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding(1251)))
                result = sr.ReadToEnd();
            result = result.Trim();
            File.WriteAllText("rates.json", result);
        }

        private void getNewsButton_Click(object sender, EventArgs e)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Rate[]));

            using (FileStream fs = new FileStream("rates.json", FileMode.OpenOrCreate))
            {
                rates = (Rate[])jsonFormatter.ReadObject(fs);
                foreach (var i in rates)
                {
                    Cur_AbbreviationComboBox.Items.Add(i.Cur_Abbreviation);
                }
            }
        }

        private void Cur_AbbreviationComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (var i in rates)
            {
                if (i.Cur_Abbreviation == Cur_AbbreviationComboBox.Text)
                {
                    Cur_IDBox.Text = i.Cur_ID.ToString();
                    Cur_OfficialRateBox.Text = i.Cur_OfficialRate.ToString();
                    Cur_ScaleBox.Text = i.Cur_Scale.ToString();
                    DateBox.Text = i.Date;
                    var bytes = Encoding.GetEncoding(1251).GetBytes(i.Cur_Name);
                    UTF8Encoding utf8 = new UTF8Encoding();
                    Cur_NameBox.Text = utf8.GetString(bytes);

                }
            }
        }
    }
}
