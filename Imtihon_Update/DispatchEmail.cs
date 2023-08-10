using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Imtihon_Update.Interfaces;
namespace Imtihon_Update
{
    public static class DispatchEmail

    {
            //ismiz
            /*var name = Console.ReadLine();
                    Console.WriteLine("email");
            var email = Console.ReadLine();
                    Console.WriteLine("enter passaword");
            var pass = Console.ReadLine();
                    var Email = new EmailService(email, pass);
                    Email.SendEmail(email, name);*/

            public static bool SendEmail(string receiverEmail, string name)
            {
                try
                {
                    var CredentialAddress = "abdurahmonsadriddinov0412@gmail.com";
                    var CredentialPassword = "bypucbhumkeghlab";

                    var mail = new MailMessage(CredentialAddress, receiverEmail);
                    mail.Subject = "Siz muvaffaqiyatli registratsiyadan o'tdingiz";
                    mail.Body = "Hurmatli {{User}}, siz sistemadan muvaffaqiyatli o'tdingiz Tabriklaymiz".Replace("{{User}}", name);
                    var smtpClient = new SmtpClient("smtp.gmail.com", 587); // 
                    smtpClient.Credentials = new NetworkCredential(CredentialAddress, CredentialPassword);
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(mail);
                    return true;
                }
                catch { return false; }
            }
        }

    }