
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfsendemail
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string SendEmail(string gmailUserAddress, string gmailUserPassword,
        string emailTo, string ccTo, string subject, string body, bool isBodyHtml);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "wcfsendemail.ContractType".
    //[DataContract]
    //public class SendEmail
    //{
    //    string gmailUserName = string.Empty;
    //    string gmailUserPassword = string.Empty;
    //    string emailTo = string.Empty;
    //    string ccTo = string.Empty;
    //    string subject = string.Empty;
    //    string body = string.Empty;
    //    //bool isBodyHtml = string.IsBodyHtml;
    //    //string empid;

    //    [DataMember]
    //    public string UserName
    //    {
    //        get { return gmailUserName; }
    //        set { gmailUserName = value; }
    //    }
    //    [DataMember]
    //    public string Password
    //    {
    //        get { return gmailUserPassword; }
    //        set { gmailUserPassword = value; }
    //    }
    //    [DataMember]
    //    public string EmailTo
    //    {
    //        get { return emailTo; }
    //        set { emailTo = value; }
    //    }

    //    [DataMember]
    //    public string CCTo
    //    {
    //        get { return ccTo; }
    //        set { ccTo = value; }
    //    }

    //    [DataMember]
    //    public string Subject
    //    {
    //        get { return subject; }
    //        set { subject = value; }
    //    }

    //    [DataMember]
    //    public string IsBodyHtml
    //    {
    //        get { return IsBodyHtml; }
    //        set { IsBodyHtml = value; }
    //    }


    //    [DataMember]
    //    public string Body
    //    {
    //        get { return body; }
    //        set { body = value; }
    //    }


    //}
}