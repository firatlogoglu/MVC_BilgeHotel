using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.COMMON.Tools
{
    public class MailSender
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email">E-Posta Adresi</param>
        /// <param name="message">Mesaj Gövdesi</param>
        /// <param name="subject">Konuyu</param>
        public static void SendEmail(string email, string message, string subject)
        {
            //TODO: EMAILADDRESS kısımlarına Hotelin E-Posta adressi gelecek.
            //TODO: EMAILPASSWORD kısmına E-Posta sifreniz gelecek.
            //TODO: SMTP Port'u Varsayılan olarak 587 olarak verilmiştir, hotelin kullandığı e-posta servisini kendi portunu yazınız.
            //TODO: SMTP Host'u Adresi varsayılan olarak "smtp.office365.com" olarak verilmiştir, hotelin kullandığı e-posta servisini kendi smtp host adresini yazınız.
            //TODO: EnableSsl = true varsayılan olarak verilmiştir.

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("EMAILADDRESS", "MVC Hotel");
            mailMessage.To.Add(email);
            mailMessage.Subject = subject;
            mailMessage.Body = message;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("EMAILADDRESS", "EMAILPASSWORD");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.office365.com";
            smtpClient.EnableSsl = true;
            smtpClient.Send(mailMessage);
        }
    }
}
