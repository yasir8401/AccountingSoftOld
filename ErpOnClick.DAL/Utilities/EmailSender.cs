using ErpOnClick.DAL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ErpOnClick.DAL.Utilities
{
    public class EmailSender
    {
        public string SendMailForFinallyAdmitted(string username,string email,string SSN,string Password)
        {
            string emailTo = email;
            try
            {
                string FilePath = @"C:\inetpub\wwwroot\ErpOnClick\Files\finalAdmittedEmail.html";
                StreamReader str = new StreamReader(FilePath);
                string MailText = str.ReadToEnd();
                str.Close();
                MailText = MailText.Replace("[NAME]", username);
                MailText = MailText.Replace("[SSN]", SSN);
                MailText = MailText.Replace("[PWD]", Password);
                MailText = MailText.Replace("[OPERA_URL]", "<a href='http://185.247.119.175:88/student'>Click here</a>");

                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("hccostcenter@gmail.com", emailTo);
                mm.Subject = "Finally Admitted Notification";
                mm.Body = MailText;
                mm.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();

                NetworkCred.UserName = "hccostcenter@gmail.com";
                NetworkCred.Password = "HCCOSTCENTER";
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                try
                {
                    smtp.Send(mm);
                    return "";
                    //return Json(new { status = "Download", data = "Quotation Downloaded Successfully" });
                }
                catch (Exception e)
                {
                    return e.Message.ToString();
                    //return Json(new { status = "Exception", data = e.Message.ToString() });

                }
            }
            catch
            {
                throw;
            }
            //return Json(expObj);
        }
        public string SendMailForInitiallyAdmitted(string username,string email)
        {
            string emailTo = email;
            try
            {
                //Fetching Email Body Text from EmailTemplate File.  
                string FilePath = @"C:\inetpub\wwwroot\ErpOnClick\Files\InitAdmittedEmail.html";
                StreamReader str = new StreamReader(FilePath);
                string MailText = str.ReadToEnd();
                str.Close();
                MailText = MailText.Replace("[NAME]", username);
                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("hccostcenter@gmail.com", emailTo);
                mm.Subject = "Initially Admitted Notification";
                mm.Body = MailText;
                mm.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();

                NetworkCred.UserName = "hccostcenter@gmail.com";
                NetworkCred.Password = "HCCOSTCENTER";
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                try
                {
                    smtp.Send(mm);
                    return "";
                    //return Json(new { status = "Download", data = "Quotation Downloaded Successfully" });
                }
                catch (Exception e)
                {
                    return e.Message.ToString();
                    //return Json(new { status = "Exception", data = e.Message.ToString() });

                }
            }
            catch
            {
                throw;
            }
            //return Json(expObj);
        }
        public string SendMail(string username, string Password, string email)
        {
            try
            {
                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("hccostcenter@gmail.com", email);
                mm.Subject = "Registration Notification";
                mm.Body = "Your Cnic Number is : "+ username + "  and Your Password is :"+ Password + "  Use this link to login (http://185.247.119.175:88/student)";
                mm.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();

                NetworkCred.UserName = "hccostcenter@gmail.com";
                NetworkCred.Password = "HCCOSTCENTER";
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                try
                {
                    smtp.Send(mm);
                    return "";
                 
                }
                catch (Exception e)
                {
                    return e.Message.ToString();
                }
            }
            catch(Exception e)
            {
                return e.Message.ToString();
            }
        }
        public string WarningMail(string LetterType, string Name, string email)
        {
            try
            {
                
                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("hccostcenter@gmail.com", email);
                mm.Subject = "Warning Notification";
                if (LetterType == "047001")
                {
                    LetterType = "Waning";
                    mm.Body = "Dear : " + Name + "," + LetterType + " Is issued,kindly check the Portal.";

                }
                else if (LetterType == "047002")
                {
                    LetterType = "Disciplinary action";
                    mm.Body = "Dear : " + Name + "," + LetterType + " Is taken against you,kindly check the Portal.";

                }
                else if (LetterType == "047003")
                {
                    LetterType = "Absent";
                    mm.Body = "Dear : " + Name + ", " + LetterType + " Warning is issued, kindly check the Portal.";

                }
                mm.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();

                NetworkCred.UserName = "hccostcenter@gmail.com";
                NetworkCred.Password = "HCCOSTCENTER";
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                try
                {
                    smtp.Send(mm);
                    return "";

                }
                catch (Exception e)
                {
                    return e.Message.ToString();
                }
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
        public string StudentAppliedSendMail(string firstName, int AdmissionForm, int userId)
        {
            try
            {
                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage("hccostcenter@gmail.com", "aamirzaib091@gmail.com");
                mm.Subject = "Admission Notification";
                mm.Body = "Mr : " + firstName + "  Is Applied for Admission, AdmissionFormId is :" + AdmissionForm + " And StudentUserId is " + userId;
                mm.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();

                NetworkCred.UserName = "hccostcenter@gmail.com";
                NetworkCred.Password = "HCCOSTCENTER";
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = NetworkCred;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                try
                {
                    smtp.Send(mm);
                    return "";

                }
                catch (Exception e)
                {
                    return e.Message.ToString();
                }
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
    }
}
