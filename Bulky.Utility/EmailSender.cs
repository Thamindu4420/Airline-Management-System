using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RaythosAerospace.Utility {
    public class EmailSender : IEmailSender {
        public Task SendEmailAsync(string email, string subject, string htmlMessage) {

            //logic to send email
            //MailMessage message = new MailMessage();
            //message.From = new MailAddress("kavindu.cyber2@gmail.com", "Raythos Aerospace");
            //message.To.Add(email);
            //message.Subject = subject;
            //message.IsBodyHtml = true;
            //message.Body ="AAAA";
            //SmtpClient client = new SmtpClient("smtp.gmail.com");
            //client.EnableSsl = true;
            //client.Port = 587;
            //client.UseDefaultCredentials = true;
            //client.Credentials = new System.Net.NetworkCredential("kavindu.cyber2@gmail.com", "erkozgxlkqnesoey");
            //client.Send(message);
           
            return Task.CompletedTask;
        }

        public void SendEmail(string email, string subject, string htmlMessage)
        {

            MailMessage message = new MailMessage();
            message.From = new MailAddress("kavindu.cyber2@gmail.com", "Raythos Aerospace");
            message.To.Add(email);
            message.Subject = subject;
            message.IsBodyHtml = true;
            message.Body = "AAAA";
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.Port = 587;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential("kavindu.cyber2@gmail.com", "lkyfnzgieflvnlsc");
            client.Send(message);
        }
    }
}
