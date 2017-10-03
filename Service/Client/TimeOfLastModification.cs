using System.Runtime.Serialization;

namespace Client
{
    [DataContract]
    public class TimeOfLastModification
    {
        [DataMember]
        public string time;
    }
}
