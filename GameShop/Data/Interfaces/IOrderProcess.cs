using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
namespace GameShop.Data.Interfaces
{
    public interface IOrderProcess
    {
        public void SendEmail(string email, string subject, string message);
    }
}
 