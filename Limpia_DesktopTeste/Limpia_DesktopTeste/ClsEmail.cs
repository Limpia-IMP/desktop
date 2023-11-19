using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MailKit;
using MimeKit;
using System;
using System.Collections.Generic;
using MailKit.Security;
using System.Text.RegularExpressions;

namespace Limpia_DesktopTeste
{
    public class ClsEmail
    {
        private ImapClient client;


        public ClsEmail()
        {
            client = new ImapClient();
        }

        public void ConnectAndAuthenticate()
        {
            try
            {
                client.Connect("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                client.Authenticate("limpia.suporte@gmail.com", "xggi cpja amfc tlkm");
                client.Authenticate("limpia.suporte@gmail.com", "zqxq hagu tqdf zmbh\r\n");
                Console.WriteLine("Conexão e autenticação bem-sucedidas");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ou autenticar: " + ex.Message);
            }
        }

        public (List<string> Name, List<string> From, List<string> Subject, List<string> Text, List<UniqueId> Uids) FetchEmail(string subjectKeyword)
        {
            var emailName = new List<string>();
            var emailFrom = new List<string>();
            var emailSubjects = new List<string>();
            var emailText = new List<string>();
            var emailUids = new List<UniqueId>();

            if (!client.IsConnected)
                return (emailName, emailFrom, emailSubjects, emailText, emailUids);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            var query = SearchQuery.SubjectContains(subjectKeyword).And(SearchQuery.NotSeen);
            var uids = inbox.Search(query);

            foreach (var uid in uids)
            {
                var message = inbox.GetMessage(uid);

                string subject = message.Subject.Replace("_Duvida", "");
                string text = message.TextBody;


                string fromEmail = ExtractEmailFromText(text);
                string fromName = ExtractNameFromText(text);

                // Use the new methods here to clean up the text
                text = RemoveEmailAndNameFromText(text);
                text = RemoveEmailJSSignature(text);

                emailName.Add(fromName);
                emailFrom.Add(fromEmail);
                emailSubjects.Add(subject);
                emailText.Add(text);
                emailUids.Add(uid);
            }

            inbox.Close();
            return (emailName, emailFrom, emailSubjects, emailText, emailUids);
        }

        private string ExtractEmailFromText(string message)
        {
            string emailPattern = @"user_email_([^\n]+)";
            var emailMatch = Regex.Match(message, emailPattern);

            return emailMatch.Success ? emailMatch.Groups[1].Value : "";
        }

        private string ExtractNameFromText(string message)
        {
            string namePattern = @"user_name_([^\n]+)";
            var nameMatch = Regex.Match(message, namePattern);

            return nameMatch.Success ? nameMatch.Groups[1].Value : "";
        }

        private string RemoveEmailAndNameFromText(string text)
        {
            // Patterns to identify the name and email lines
            string namePattern = @"user_name_[^\n]+\n";
            string emailPattern = @"user_email_[^\n]+\n";

            // Remove the name and email parts from the text
            text = Regex.Replace(text, namePattern, "");
            text = Regex.Replace(text, emailPattern, "");

            return text;
        }

        private string RemoveEmailJSSignature(string message, bool isHtml = false)
        {
            string signaturePattern;
            if (isHtml)
            {
                // Flexible pattern for HTML content
                signaturePattern = @"Email\s+sent\s+via\s+<a[^>]*?>EmailJS\.com<\/a>\s*\[<a\s+href=.*?email-footer.*?>";
            }
            else
            {
                // Flexible pattern for plain text content
                signaturePattern = @"Email\s+sent\s+via\s+EmailJS\.com\s*\[https?:\/\/www\.emailjs\.com\?src=email-footer\]";
            }

            return Regex.Replace(message, signaturePattern, "", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public void SendReply(string toEmail, string subject, string body, UniqueId originalEmailId)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Suporte Limpia", "limpia.suporte@gmail.com"));
            message.To.Add(new MailboxAddress("", toEmail));
            message.Subject = subject;

            var builder = new BodyBuilder { TextBody = body };
            message.Body = builder.ToMessageBody();

            message.InReplyTo = originalEmailId.ToString();
            message.References.Add(originalEmailId.ToString());

            using (var smtp = new SmtpClient())
            {
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("limpia.suporte@gmail.com", "xggi cpja amfc tlkm");
                smtp.Send(message);
                smtp.Disconnect(true);
            }
        }

        public void MarkEmailAsRead(UniqueId uid)
        {
            if (!client.IsConnected || !client.IsAuthenticated)
                return;

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadWrite);

            inbox.AddFlags(uid, MessageFlags.Seen, true);
        }

        public void MarkEmailAsTrash(UniqueId uid)
        {
            if (!client.IsConnected || !client.IsAuthenticated)
                return;

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadWrite);

            inbox.AddFlags(uid, MessageFlags.Deleted, true);
        }

        public void Disconnect()
        {
            if (client.IsConnected)
            {
                client.Disconnect(true);
            }
        }
    }
}
