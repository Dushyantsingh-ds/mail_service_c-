using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void btnSend_Click(object sender, System.EventArgs e)
    {
        MailMessage mail = new MailMessage();

        mail.From = new MailAddress(txtFrom.Text); //IMPORTANT: This must be same as your smtp authentication address.
        mail.To.Add(txtTo.Text);

        //set the content 
        mail.Subject = txtSubject.Text;
        mail.Body = txtContent.Value;


        //send the message 
        SmtpClient smtp = new SmtpClient(txtMailServer.Text, 25);

        //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
        NetworkCredential Credentials = new NetworkCredential(txtFrom.Text, txtPass.Text);
        smtp.Credentials = Credentials;

        smtp.Send(mail);
        lblStatus.Text = "Sent email (" + txtSubject.Text + ") to " + txtTo.Text;                            
    }
    protected void btnSend_Click1(object sender, EventArgs e)
    {
        MailMessage mail = new MailMessage();

        mail.From = new MailAddress(txtFrom.Text); //IMPORTANT: This must be same as your smtp authentication address.
        mail.To.Add(txtTo.Text);

        //set the content 
        mail.Subject = txtSubject.Text;
        mail.Body = txtContent.Value;


        //send the message 
        SmtpClient smtp = new SmtpClient(txtMailServer.Text, 25);

        //IMPORANT:  Your smtp login email MUST be same as your FROM address. 
        NetworkCredential Credentials = new NetworkCredential(txtFrom.Text, txtPass.Text);
        smtp.Credentials = Credentials;

        smtp.Send(mail);
        lblStatus.Text = "Sent email (" + txtSubject.Text + ") to " + txtTo.Text;
    }
}