namespace blazor_blog_v2_2022.Services;
public interface IMailService
{
    public Task SendMailAsync(string to, string subject, string body);
}