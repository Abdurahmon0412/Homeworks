using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace N29_HT2
{
    public class EmployeeService
    {
        //EmployeeService servicedan foydalaning
        //unda HireAsync(firstname, lastname) methodi bo'lsin

        //bunda 
        //- xodimga confirmation email jo'nating 
        //- email jo'natilgungacha $"{firstname} {lastname}`s employment contract.docs" faylini yarating
        //- confirmation email jo'natib bo'lingach, welcome on board email ni jo'nating
        //- fayl yaratib bo'lingach ichiga employment contract textini yozib qo'ying
        //- welcome on board email jo'natib bo'lingach, office policies emailini jo'nating
        public EmailService emailService = new EmailService();

        #region
        private string _confirmSubject = "Subject: Confirm Your Email Address";

        private string _cofirmbody = "Dear {{Employee}},\r\n\r\nThank you for joining the team." +
            " To start your journey we need to first confirm your email address, please click on " +
            "the following link to confirm your email address:\r\n\r\nIf you received this email " +
            "mistakenly, please ignore this email.\r\n\r\nThank you";
        #endregion
        #region
        private string _welcomeEmailsubject = "Welcome On Board Email Template";
        private string _welcomeEmailbody = "Dear {{Employee}},\r\n\r\nWe are thrilled to welcome" +
            " you! We are excited to have you on board and look forward to working with you.\r\n\r\nAs" +
            " a new member of our team, we want to make sure you have everything you need to get started." +
            " Please let us know if you have any questions or need any assistance.\r\n\r\nWe wish you all " +
            "the best in your new role and look forward to your contributions to our team.\r\n\r\nBest" +
            " regards";
        #endregion
        #region


        private string _officeposiciesEmailSubject = "Office Policies and Guidelines";
        private string _officeposiciesEmailbody = "Dear {{Employee}} ,\r\n\r\nAs a member of our team," +
            " it is important that you are aware of our office policies and guidelines. These policies " +
            "are designed to ensure a safe and productive work environment for everyone.\r\n\r\nPlease " +
            "take a moment to review the attached document, which outlines our policies and guidelines. " +
            "If you have any questions or concerns, please do not hesitate to reach out to us.\r\n\r\n" +
            "Thank you for your cooperation and adherence to our policies.\r\n\r\nBest regards";
        #endregion
        private string _contractText = "Siz bilan muvaffaqiyatli shartnama imzoladik";

        private string fileNameToken = "{{firstname}}_{lastname}}'s employment contract.docs";
        public async Task HireAsync(Employee employee)
        {
            #region
            Console.WriteLine($"HireAsync thread - {Thread.CurrentThread.ManagedThreadId}");

            var fullname = employee.FirstName + employee.LastName;
            var taskcofirmation = SendConfirmationEmail(employee.EmailAddress, _confirmSubject, _cofirmbody, fullname);


            var taskCreatefile = CreateEmployeeFile(employee.FirstName, employee.LastName);

            await Task.WhenAll(taskcofirmation);

            var taskWilcomeEmail = SendWelcomeEmail(employee.EmailAddress, _welcomeEmailsubject,_welcomeEmailbody, fullname);


            await Task.WhenAll(taskCreatefile);

            var taskWriteFileContract = Task.Run(() => WriteFileContract(_contractText, employee.FirstName, employee.LastName)); 

            await Task.WhenAll(taskWilcomeEmail);

            var taskfinally = SendOfficePoliceEmail(employee.EmailAddress, _officeposiciesEmailSubject, _officeposiciesEmailbody, fullname);

            await Task.WhenAll(taskfinally);
            #endregion
        }

        private async Task<bool> SendConfirmationEmail(string recevieremail, string subject, string body,string fullname)
        {
            var result = await emailService.SendAsync(recevieremail, subject, body.Replace("{{Employee}}", fullname));
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            return result;
        }

        private  Task<FileStream> CreateEmployeeFile(string firstname,string lastname)
        {
            var fileStream = File.Create($"{firstname}_{lastname}'s employment contract.docs");
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            return Task.FromResult(fileStream);
        }

        private async Task<bool> SendWelcomeEmail(string recevemail, string subject, string body,string fullname)
        {
            Console.WriteLine($"SendWelcomeEmail thread before await - {Thread.CurrentThread.ManagedThreadId}");
            var result = await emailService.SendAsync(recevemail, subject, body.Replace("{{Employee}}", fullname));
            Console.WriteLine($"SendWelcomeEmail thread after await - {Thread.CurrentThread.ManagedThreadId}");

            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            return result;
        }

        private async Task WriteFileContract(string text,string firstname, string lastname)
        {
            var pathreplace = $"{firstname}_{lastname}";
            var path = fileNameToken.Replace("{{firstname}}_{lastname}}", pathreplace);
            await File.WriteAllTextAsync(path, text);
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        }

        private async Task<bool> SendOfficePoliceEmail(string recevemail, string subject, string body, string fullname)
        {
            var result = await emailService.SendAsync(recevemail, subject, body.Replace("{{Employee}}", fullname));
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            return result;

        }

    }
}
