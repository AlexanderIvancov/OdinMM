using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;
using System.IO;
using System.Diagnostics;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Web;
using System.Net;
using AegisImplicitMail;

namespace Odin
{
    public partial class frm_TestSimple : Form
    {
        public frm_TestSimple()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"c:/Odin/Odin.exe";
            string path1 = @"c:/Odin1/Odin.exe";

            FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(path);
            FileVersionInfo myFileVersionInfo1 = FileVersionInfo.GetVersionInfo(path1);

            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists == false
               || myFileVersionInfo != myFileVersionInfo1 )
            {
                CopyDir("c:/Odin1", "c:/Odin");

                //Console.WriteLine("Имя файла: {0}", fileInf.Name);
                //Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                //Console.WriteLine("Размер: {0}", fileInf.Length);
            }
            else
            {

            }
            Process.Start("c:/Odin/Odin.exe");

            Application.Exit();
        }
        void CopyDir(string FromDir, string ToDir)
        {
            //Replace old exe file in desctination directory
            //foreach (string s1 in Directory.GetFiles(ToDir))
            //{
            //    //delete old exe file
            //    if (s1 == "Odin.old")
            //    {
            //        File.Delete(ToDir + "\\Odin.old");
            //        break;
            //    }
            //}

            //foreach (string s1 in Directory.GetFiles(ToDir))
            //{
            //    if (s1 == "Odin.exe")
            //    {
            //        File.Copy(ToDir + "\\Odin.exe", ToDir + "\\Odin.old", true);
            //    }
            //}

            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2, true);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    // create the email message 
            //    MailMessage message = new MailMessage(
            //       txt_From.Text,
            //       txt_To.Text,
            //       "Test subject",
            //       txt_Message.Text);

            //    message.IsBodyHtml = false;

            //    // create smtp client at mail server location
            //    //SmtpClient client = new SmtpClient(Properties.Settings.Default.SMTPAddress);
            //    SmtpClient client = new SmtpClient(txt_SMTP.Text, Convert.ToInt32(txt_Port.Text));


            //    //add credentials
            //    if (chk_UseDefault.CheckState == CheckState.Checked)
            //        client.UseDefaultCredentials = true;
            //    else
            //    {
            //        client.UseDefaultCredentials = false;
            //        client.Credentials = new NetworkCredential(txt_UserName.Text, txt_Password.Text);
            //        //client.ClientCertificates = new System.Security.Cryptography.X509Certificates.X509CertificateCollection()
            //    }

            //    client.EnableSsl = chk_UseSSL.CheckState == CheckState.Checked ? true : false;

            //    // send message
            //    client.Send(message);

            //    MessageBox.Show( "Message sent to " + txt_To.Text + " at " + DateTime.Now.ToString() + ".");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
            SendEmail();
        }

        private void SendEmail()
        {
            var mail = txt_From.Text;
            var host = txt_SMTP.Text;
            var user = txt_UserName.Text;
            var pass = txt_Password.Text;

            //Generate Message 
            var mymessage = new MimeMailMessage();
            mymessage.From = new MimeMailAddress(mail);
            mymessage.To.Add(txt_To.Text);
            mymessage.Subject = "test";
            mymessage.Body = txt_Message.Text;
            //Attachment data = new Attachment();
            //mymessage.Attachments.Add(data);

            //Create Smtp Client
            var mailer = new MimeMailer(host, 465);
            if (chk_UseDefault.CheckState == CheckState.Unchecked)
            {
                
                mailer.User = user;
                mailer.Password = pass;
                mailer.SslType = SslMode.Ssl;
                mailer.AuthenticationMode = AuthenticationType.Base64;
            }
            else
            {
                //mailer.User = user;
                //mailer.Password = pass;
                mailer.SslType = SslMode.Ssl;
                mailer.AuthenticationMode = AuthenticationType.UseDefualtCridentials;
            }

            //Set a delegate function for call back
            mailer.SendCompleted += compEvent;
            mailer.SendMailAsync(mymessage);
        }

        //Call back function
        private void compEvent(object sender, AsyncCompletedEventArgs e)
        {
            if (e.UserState != null)
                Console.Out.WriteLine(e.UserState.ToString());

            Console.Out.WriteLine("is it canceled? " + e.Cancelled);

            if (e.Error != null)
                Console.Out.WriteLine("Error : " + e.Error.Message);
        }
    }
}
