using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfsendemail
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
       
            private static string SMTPSERVER = "smtp.office365.com";
            private static int PORTNO = 587;

            public string SendEmail(string gmailUserName, string gmailUserPassword,
               string emailToAddress, string ccemailTo, string subject, string body, bool isBodyHtml)
            {
                if (gmailUserName == null || gmailUserName.Trim().Length == 0)
                {
                    return "User Name Empty";
                }
                if (gmailUserPassword == null || gmailUserPassword.Trim().Length == 0)
                {
                    return "Email Password Empty";
                }
                if (emailToAddress == null || emailToAddress.Length == 0)
                {
                    return "Email To Address Empty";
                }

                List<string> tempFiles = new List<string>();

                SmtpClient smtpClient = new SmtpClient(SMTPSERVER, PORTNO);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("leaves@chetu.com", "cHLeaV@2021");
                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress("leaves@chetu.com");
                    message.Subject = subject == null ? "" : subject;
                    message.Body = body == null ? "" : body;
                    message.IsBodyHtml = isBodyHtml;

                //foreach (string email in emailToAddress)
                //    {
                        message.To.Add(emailToAddress);
                    //}
                    if (ccemailTo != null && ccemailTo.Length > 0)
                    {
                        //foreach (string emailCc in ccemailTo)
                        //{
                            message.CC.Add(ccemailTo);
                        //}
                    }
                    try
                    {
                        smtpClient.Send(message);
                        return "Email Send SuccessFully";
                    }
                    catch(Exception Ex)
                    {
                        return "Email Send failed"+Ex.ToString();
                    }
                    finally
                    {
                    smtpClient.Send(message);
                    //return "Email Send SuccessFully";
                    }   
                }
            }
        
    }
}