using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    [DataContract]
    public class MailInformation
    {
        [DataMember]
        public string smtpServer { get; set; }
        [DataMember]
        public string emailOfRecipient { get; set; }
    }
}
