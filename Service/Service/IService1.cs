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
        void GetTimeOfUpdate();
    }

    [DataContract]
    public class TimeOfLastModification
    {
        [DataMember]
        public string time;
    }

}
