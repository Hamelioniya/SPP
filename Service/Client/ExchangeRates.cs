using Client.ServiceReference1;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class ExchangeRates : Form
    {
        Rate[] rates;
        delegate void JsonDeserializationCallback(Rate item);
        Service1Client client;

        public ExchangeRates()
        {
            client = new Service1Client();

            InitializeComponent();
            timer.Enabled = true;

            try
            {
                client.GetJsonDoc();
                timeTextBox.Text = client.GetTimeOfUpdate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private string TakePathOfFile(string filename)
        {
            string location = AppDomain.CurrentDomain.BaseDirectory;
            string[] split = location.Split(new Char[] { '\\'});
            string path = split[0];
            for (int i = 1; i < split.Length-4; i++)
            {
                path = path + "\\" + split[i];
            }
            return path + "\\" + filename;
        }

        private void getNewsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Thread myThread = new Thread(new ThreadStart(JsonFileDeserialization));
                myThread.Start();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void JsonFileDeserialization()
        {
            string fileLocation = TakePathOfFile("rates.json");

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Rate[]));

            using (FileStream fs = new FileStream(fileLocation, FileMode.OpenOrCreate))
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

        private void Cur_AbbreviationComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
            try
            {
                client.GetJsonDoc();
                timeTextBox.Text = client.GetTimeOfUpdate();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void ExchangeRates_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.MailInformation mInf = new ServiceReference1.MailInformation();
            mInf.emailOfRecipient = emailTextBox.Text.Trim();
            mInf.smtpServer = serverTextBox.Text.Trim();

            try { client.SendMessage(mInf); }
            catch(Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            MessageBox.Show("Сообщение отправлено.");
        }
    }
}
