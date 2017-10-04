using System.Runtime.Serialization;
using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void GetJsonDoc();
        [OperationContract]
        string GetTimeOfUpdate();
        [OperationContract]
        void SendMessage(MailInformation mInf);
    }

    [DataContract]
    public class TimeOfLastModification
    {
        [DataMember]
        public string time { get; set; }
    }

    [DataContract]
    public class MailInformation
    {
        [DataMember]
        public string smtpServer { get; set; }
        [DataMember]
        public string emailOfRecipient { get; set; }
    }

}
