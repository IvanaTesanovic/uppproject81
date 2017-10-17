using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace UppApplication.Helpers
{
    public class EmailHelper
    {
        public void SendEmail(string subject, string body, string from, string to)
        {
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("inna0507@gmail.com", "ivana5793"),
                EnableSsl = true
            };
            //mailClient.Send(from, to, subject, body);
            Console.WriteLine("Imejl je poslat");
        }
    }
}