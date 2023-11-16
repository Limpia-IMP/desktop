using MailKit.Net.Imap;
using MailKit.Net.Smtp;
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

        // Método atualizado para retornar também os UniqueIds dos e-mails
        public (List<string> Name, List<string> From, List<string> Subject, List<string> Text, List<UniqueId> Uids) FetchEmail(string subjectKeyword)
        {
            var emailName = new List<string>();
            var emailFrom = new List<string>();
            var emailSubjects = new List<string>();
            var emailText = new List<string>();
            var emailUids = new List<UniqueId>();

            if (!client.IsConnected)
                return (emailName,emailFrom, emailSubjects, emailText, emailUids);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            var query = SearchQuery.SubjectContains(subjectKeyword).And(SearchQuery.NotSeen);
            var uids = inbox.Search(query);

            foreach (var uid in uids)
            {
                var message = inbox.GetMessage(uid);
                string fromEmail = message.From.Mailboxes.FirstOrDefault()?.Address ?? "Desconhecido";
                string fromName = ExtractNameFromEmail(fromEmail);
                string subject = message.Subject.Replace("_Duvida", "");
                string text = message.TextBody;
                emailName.Add(fromName);
                emailFrom.Add(fromEmail);
                emailSubjects.Add(subject);
                emailText.Add(text);
                emailUids.Add(uid);
            }

            inbox.Close();
            return (emailName, emailFrom, emailSubjects, emailText, emailUids);
        }

        private string ExtractNameFromEmail(string email)
        {
            var namePart = email.Split('@')[0];
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(namePart.Replace('.', ' ').Replace('_', ' '));
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
                smtp.Authenticate("limpia.suporte@gmail.com", "zqxq hagu tqdf zmbh\r\n");
                smtp.Send(message);
                smtp.Disconnect(true);
            }
        }
        public void MarkEmailAsRead(UniqueId uid)
        {
            if (!client.IsConnected || !client.IsAuthenticated)
                return;

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadWrite); // Abre a caixa de entrada para leitura/escrita

            // Marca a mensagem como lida
            inbox.AddFlags(uid, MessageFlags.Seen, true);
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
