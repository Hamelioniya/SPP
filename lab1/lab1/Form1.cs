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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        Rate[] rates;
        delegate void JsonDeserializationCallback(Rate item);

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            GetJsonDoc();
        }

        private async void GetJsonDoc()
        {
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("http://www.nbrb.by/API/ExRates/Rates?Periodicity=0");
            httpRequest.Method = "GET";
            httpRequest.ContentType = "text/json";
            httpRequest.KeepAlive = true;
 
            System.Threading.Tasks.Task<System.Net.WebResponse> responseTask =
               httpRequest.GetResponseAsync();

            var resp = await responseTask;
            string result = "";
            using (StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding(1251)))
                result = sr.ReadToEnd();
            result = result.Trim();
            File.WriteAllText("rates.json", result);
            HttpWebResponse r = (HttpWebResponse)resp;

            timeTextBox.Text = r.LastModified.ToString();
        }

        private void getNewsButton_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(JsonFileDeserialization));
            myThread.Start();
        }

        private void JsonFileDeserialization()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Rate[]));

            using (FileStream fs = new FileStream("rates.json", FileMode.OpenOrCreate))
            {
                rates = (Rate[])jsonFormatter.ReadObject(fs);
                foreach (var i in rates)
                {

                    this.AddItem(i);
                }
            }
        }

        private void AddItem(Rate item)
        {
            //Получает значение, показывающее, следует ли вызывающему оператору обращаться к методу invoke во время вызовов метода 
            //из элемента управления, так как вызывающий оператор находится не в том потоке, в котором был создан элемент управления.
            if (Cur_AbbreviationComboBox.InvokeRequired)
            {
                //Если InvokeRequired возвращает true, вызовите Invoke с делегатом, фактически вызывающим элемент управления.
                JsonDeserializationCallback d = new JsonDeserializationCallback(AddItem);
                //Выполняет делегат в том потоке, которому принадлежит базовый дескриптор окна элемента управления.
                Invoke(d, new object[] { item });
            }
            else
            {
                //Если InvokeRequired возвращает false, вызовите элемент управления напрямую.
                Cur_AbbreviationComboBox.Items.Add(item.Cur_Abbreviation);
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

        private void timer_Tick(object sender, EventArgs e)
        {
            GetJsonDoc();
        }
    }
}
