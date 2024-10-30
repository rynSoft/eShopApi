using eShop.Domain.Settings;
using System.Threading.Tasks;

namespace eShop.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
