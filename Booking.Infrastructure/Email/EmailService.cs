using Bookify.Application.Abstractions.Email;

namespace Booking.Infrastructure.Email;

internal sealed class EmailService : IEmailService
{
    public Task SendAsync(Bookify.Domain.Users.Email recipient, string subject, string body)
    {
        return Task.CompletedTask;
    }
}
