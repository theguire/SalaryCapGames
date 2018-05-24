using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SalaryCapGames.Services
{
    // This class is used by the application to send email for account confirmation and password reset.
    // For more details see https://go.microsoft.com/fwlink/?LinkID=532713
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync( string email, string subject, string message )
        {
            SmtpClient client = new SmtpClient( "smtp.gmail.com", 587 )
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential( "stephen.g.mcguire@gmail.com", "zZd57xgOnfe9" ),
                EnableSsl = true
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress( "stephen.g.mcguire@gmail.com" )
            };
            mailMessage.To.Add( email );
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = subject;
            client.Send( mailMessage );

            return Task.CompletedTask;

        }
    }
}
