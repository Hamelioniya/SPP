using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;

namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        string time;

        private string TakePathOfFile(string filename)
        {
            string location = AppDomain.CurrentDomain.BaseDirectory;
            string[] split = location.Split(new Char[] { '\\' });
            string path = split[0];
            for (int i = 1; i < split.Length-2; i++)
            {
                path = path + "\\" + split[i];
            }
            return path + "\\" + filename;
        }

        public async void GetJsonDoc()
        {
            try
            {
                string fileLocation = TakePathOfFile("rates.json");

                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create("http://www.nbrb.by/API/ExRates/Rates?Periodicity=0");
                httpRequest.Method = "GET";
                httpRequest.ContentType = "text/json";
                httpRequest.KeepAlive = true;

                System.Threading.Tasks.Task<System.Net.WebResponse> responseTask =
                   httpRequest.GetResponseAsync();

                var resp = await responseTask;
                string resultOfResponse = "";
                using (StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding(1251)))
                    resultOfResponse = sr.ReadToEnd();
                resultOfResponse = resultOfResponse.Trim();
                File.WriteAllText(fileLocation, resultOfResponse);

                HttpWebResponse r = (HttpWebResponse)resp;

                time = r.LastModified.ToString();
            }
            catch (Exception ex) { Console.Out.WriteLine(ex.Message.ToString()); }
        }

        public string GetTimeOfUpdate()
        {
            return time;
        }

        public async void SendMessage(MailInformation mInf)
        {
            var fromAddress = new MailAddress("galtsova98@gmail.com", "Anastasiya");
            var toAddress = new MailAddress(mInf.emailOfRecipient);
            const string fromPassword = "password";//необходимо ввести пароль от почты
            const string subject = "Информация о курсе валют";
            const string body = "Файл с информайией о курсе валют находится в приложении.";

            var client = new SmtpClient
            {
                Host = mInf.smtpServer,
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
            })
            {
                if (File.Exists(TakePathOfFile("rates.txt")))
                    message.Attachments.Add(new Attachment(TakePathOfFile("rates.txt")));
                await client.SendMailAsync(message);
            }
        }
    }
}
