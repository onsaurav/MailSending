using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Web.Mail;

namespace MailSending
{
    public partial class frmMailSending : Form
    {
        public frmMailSending()
        {
            InitializeComponent();
        }

        private void txtSender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMailSending_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.To = txtTo.Text.Trim();
            mail.From = txtSender.Text.Trim();
            mail.Subject = "Auto Mailing";
            mail.Body = txtText.Text.Trim();
            //MailAttachment attachment = new MailAttachment(pathname);
            //mail.Attachments.Add(attachment);
            SmtpMail.SmtpServer = txtServer.Text.Trim();
            SmtpMail.Send(mail);
        }
    }
}
