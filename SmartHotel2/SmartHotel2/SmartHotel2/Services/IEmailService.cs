
namespace SmartHotel2.Services
{
    public interface IEmailService
    {
        void Send(string email, string title, string content);
    }
}
