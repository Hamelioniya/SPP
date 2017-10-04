using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.Text;

namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
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

            try { File.WriteAllText(fileLocation, resultOfResponse); }
            catch(Exception ex) { }

            HttpWebResponse r = (HttpWebResponse)resp;

            time = r.LastModified.ToString();
            GetTimeOfUpdate();
        }

        public void GetTimeOfUpdate()
        {
            string fileWithTimeLocation = TakePathOfFile("time.json");

            TimeOfLastModification timeOfLastUpdate = new TimeOfLastModification();
            timeOfLastUpdate.time = time;

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(TimeOfLastModification));

            using (FileStream fs = new FileStream(fileWithTimeLocation, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, timeOfLastUpdate);
                fs.Close();
            }
        }

        public async void SendMessage()
        {
            string fileWithEmailInformation = TakePathOfFile("email.json");
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(MailInformation));
            MailInformation mInf;

            using (FileStream fs = new FileStream(fileWithEmailInformation, FileMode.OpenOrCreate))
            {
                mInf = (MailInformation)jsonFormatter.ReadObject(fs);
            }

            var fromAddress = new MailAddress("galtsova98@gmail.com", "Anastasiya");
            var toAddress = new MailAddress(mInf.emailOfRecipient);
            const string fromPassword = "anastasiyashit";
            const string subject = "Информация о курсе валют";
            const string body = "Файл для получения курса валют находится в приложении.";

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
                if (File.Exists(TakePathOfFile("rates.json")))
                    message.Attachments.Add(new Attachment(TakePathOfFile("rates.json")));
                await client.SendMailAsync(message);
            }
        }
    }
}
