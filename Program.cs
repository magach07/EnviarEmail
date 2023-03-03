using System.Net;
using System.Net.Mail;
using System.Text;

namespace EnviarEmail;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            MailMessage mailMessage = new MailMessage("jonathanmagacho@gmail.com", "jonathanmagacho@gmail.com");

            mailMessage.Subject = "Titulo de Exemplo";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "<p> Esse é um e-mail enviado automaticamente pela API de Jonathan Magacho</p>";
            mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
            mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("jonathanmagacho@gmail.com", "bwnmlugilverfsbg");

            client.EnableSsl = true;
            
            client.Send(mailMessage);

            Console.Write("E-mail enviado com sucesso");
        }
        catch (Exception e)
        {
            Console.Write("Ocorreu um erro durante o envio do e-mail. " + e.Message);
        }
    }
}