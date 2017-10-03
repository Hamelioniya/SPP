using System.Runtime.Serialization;

namespace Client
{
    [DataContract]
    public class Rate
    {
        [DataMember]
        public int Cur_ID { get; set; }
        [DataMember]
        public string Date { get; set; }
        [DataMember]
        public string Cur_Abbreviation { get; set; }
        [DataMember]
        public int Cur_Scale { get; set; }
        [DataMember]
        public string Cur_Name { get; set; }
        [DataMember]
        public double Cur_OfficialRate { get; set; }

        public Rate(int Cur_ID, string Date, string Cur_Abbreviation, int Cur_Scale, string Cur_Name, double Cur_OfficialRate)
        {
            this.Cur_ID = Cur_ID;
            this.Date = Date;
            this.Cur_Abbreviation = Cur_Abbreviation;
            this.Cur_Scale = Cur_Scale;
            this.Cur_Name = Cur_Name;
            this.Cur_OfficialRate = Cur_OfficialRate;
        }
    }
}
