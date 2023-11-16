using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;
using System;
using System.Collections.Generic;
using MailKit.Security;
using System.Linq;
using System.Globalization;

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
                client.Authenticate("limpia.suporte@gmail.com", "zqxq hagu tqdf zmbh\r\n");
                Console.WriteLine("Conexão e autenticação bem-sucedidas");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ou autenticar: " + ex.Message);
            }
        }

        public (List<string> From, List<string> Subject) FetchEmailsWithSubject(string subjectKeyword)
        {
            var emailFrom = new List<string>();
            var emailSubjects = new List<string>();

            if (!client.IsConnected)
                return (emailFrom, emailSubjects);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            var query = SearchQuery.SubjectContains(subjectKeyword);
            var uids = inbox.Search(query);

            foreach (var uid in uids)
            {
                var message = inbox.GetMessage(uid);
                string fromEmail = message.From.Mailboxes.FirstOrDefault()?.Address ?? "Desconhecido";
                string fromName = ExtractNameFromEmail(fromEmail);
                string subject = message.Subject.Replace("_Duvida", "");
                emailFrom.Add(fromName);
                emailSubjects.Add(subject);
            }

            inbox.Close();
            return (emailFrom, emailSubjects);
        }
        private string ExtractNameFromEmail(string email)
        {
            var namePart = email.Split('@')[0];
            // Substitui pontos e sublinhados por espaços e capitaliza cada palavra.
            // Ajuste conforme necessário.
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(namePart.Replace('.', ' ').Replace('_', ' '));
        }

        public (List<string> From, List<string> Subject, List<String> Text) FetchEmail(string subjectKeyword)
        {
            var emailFrom = new List<string>();
            var emailSubjects = new List<string>();
            var emailText = new List<string>();

            if (!client.IsConnected)
                return (emailFrom, emailSubjects, emailText);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            var query = SearchQuery.SubjectContains(subjectKeyword);
            var uids = inbox.Search(query);

            foreach (var uid in uids)
            {
                var message = inbox.GetMessage(uid);
                string fromEmail = message.From.Mailboxes.FirstOrDefault()?.Address ?? "Desconhecido";
                string fromName = ExtractNameFromEmail(fromEmail);
                string subject = message.Subject.Replace("_Duvida", "");
                string text = message.TextBody;
                emailFrom.Add(fromName);
                emailSubjects.Add(subject);
                emailText.Add(text);
            }

            inbox.Close();
            return (emailFrom, emailSubjects, emailText);
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
