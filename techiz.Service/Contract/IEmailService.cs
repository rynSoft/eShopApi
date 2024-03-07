using techiz.Domain.Settings;
using System.Threading.Tasks;

namespace techiz.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
