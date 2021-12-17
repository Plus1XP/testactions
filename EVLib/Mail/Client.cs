﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace EVLib.Mail
{
    public class Client
    {
        public ServerSettings Server;
        public MessageField Field;

        public Client()
        {

        }

        /// <summary>
        /// Initializes client for sending emails via STMP.
        /// </summary>
        /// <param name="serverSettings">Initializes a new instance of the Server Settings class with the specified settings.</param>
        public Client(ServerSettings serverSettings)
        {
            Server = serverSettings;
        }

        /// <summary>
        /// Initializes client for sending emails via STMP.
        /// </summary>
        /// <remarks>
        /// This overload sets "UseDefaultCredentials" to true.
        /// This will use the credentials of the current logged in user.
        /// </remarks>
        /// <param name="host">Email servers host address.</param>
        /// <param name="port">Email servers port.</param>
        /// <param name="enableSsl">Specifies whether the email server requires SSL.</param>
        public Client(string host, int port, bool enableSsl)
        {
            Server = new ServerSettings();
            Server.Host = host;
            Server.Port = port;
            Server.UseDefaultCredentials = true;
            Server.EnableSsl = enableSsl;
        }

        /// <summary>
        /// Initializes client for sending emails via STMP.
        /// </summary>
        /// <param name="host">Email servers host address.</param>
        /// <param name="port">Email servers port.</param>
        /// <param name="username">Username to login to email Server.</param>
        /// <param name="password">Password to login to email server.</param>
        /// <param name="enableSsl">Specifies whether the email server requires SSL.</param>
        public Client(string host, int port, string username, string password, bool enableSsl)
        {
            Server = new ServerSettings();
            Server.Host = host;
            Server.Port = port;
            Server.UseDefaultCredentials = false;
            Server.Username = username;
            Server.Password = password;
            Server.EnableSsl = enableSsl;
        }

        /// <summary>
        /// Sends an email via SMTP
        /// </summary>
        /// <remarks>
        /// ServerSettings and MessageField must be set to the public fields.
        /// </remarks>
        /// <returns>Sent confirmation as String.</returns>
        public string Send()
        {
            return SendSMTP();
        }

        /// <summary>
        /// Sends an email via SMTP
        /// </summary>
        /// <remarks>
        /// ServerSettings must be passed into the constructor.
        /// </remarks>
        /// <param name="messageField">Initializes a new instance of the MessageField class with the specified fields.</param>
        /// <returns>Sent confirmation as String.</returns>
        public string Send(MessageField messageField)
        {
            Field = messageField;
            return SendSMTP();
        }

        /// <summary>
        /// Sends an email via SMTP.
        /// </summary>
        /// <param name="senderName">Display name of Sender.</param>
        /// <param name="senderEmail">Email address of sender.</param>
        /// <param name="recipientName">Display name of recipient.</param>
        /// <param name="recipientEmail">Email address of recipient.</param>
        /// <param name="subject">Email subject.</param>
        /// <param name="body">Email message body.</param>
        /// <param name="attachmentPath">Email attachment file path.</param>
        /// <returns>Sent confirmation as String.</returns>
        public string Send(string senderName, string senderEmail, string recipientName,
            string recipientEmail, string subject, string body, string attachmentPath = null)
        {
            Field = new MessageField();
            Field.SenderName = senderName;
            Field.SenderEmail = senderEmail;
            Field.RecipientName = recipientName;
            Field.RecipientEmail = recipientEmail;
            Field.Subject = subject;
            Field.Body = body;
            Field.AttachmentPath = attachmentPath;
            return SendSMTP();
        }

        /// <summary>
        /// Sends an email via the SMTP Server using specified Server Settings and Message Fields.
        /// </summary>
        /// <remarks>
        /// If UseDefaultCredentials is set to true it will use the defaults,
        /// otherwise it will first look in Credentials property and then in the web.config (default).
        /// If none are set it will send the email anonymously.
        /// If you set 'UseDefaultCredentials = false' you must do it BEFORE setting Credentials,
        /// as the change nulls any existing credentials set
        /// </remarks>
        /// <returns>Delivery status as a String.</returns>
        private string SendSMTP()
        {
            try
            {
                SmtpClient mailServer = new SmtpClient();

                mailServer.Host = Server.Host;
                mailServer.Port = Server.Port;
                // must be set before NetworkCredentials
                mailServer.UseDefaultCredentials = Server.UseDefaultCredentials;

                if (Server.UseDefaultCredentials == false)
                {
                    mailServer.Credentials = new NetworkCredential(Server.Username, Server.Password);
                }

                mailServer.EnableSsl = Server.EnableSsl;

                // add from,to mailaddresses
                MailAddress from = new MailAddress(Field.SenderEmail, Field.SenderName);
                MailAddress to = new MailAddress(Field.RecipientEmail, Field.RecipientName);
                MailMessage email = new MailMessage(from, to);

                // TODO Add option to use different reply to address.
                // add ReplyTo
                MailAddress replyto = new MailAddress(Field.SenderEmail);
                email.ReplyToList.Add(replyto);

                // set subject and encoding
                email.Subject = Field.Subject;
                email.SubjectEncoding = System.Text.Encoding.UTF8;

                // add Attachment
                if (Field.AttachmentPath != null)
                {
                    email.Attachments.Add(new Attachment(Field.AttachmentPath));
                }

                // set body-message and encoding
                email.Body = Field.Body;
                email.BodyEncoding = System.Text.Encoding.UTF8;

                // text or html
                email.IsBodyHtml = true;

                // set Priority
                email.Priority = MailPriority.Normal;

                // send Mail
                mailServer.Send(email);

                return "Mail Sent!";
            }
            catch (SmtpException ex)
            {
                return "SmtpException has occured: " + ex.Message;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
