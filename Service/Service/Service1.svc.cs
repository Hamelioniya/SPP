using System;
using System.IO;
using System.Net;
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
            File.WriteAllText(fileLocation, resultOfResponse);

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

            using (FileStream fs = new FileStream(fileWithTimeLocation, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, timeOfLastUpdate);
            }
        }
    }
}
