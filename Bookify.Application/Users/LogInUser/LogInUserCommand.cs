using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Users.LogInUser;

public record LogInUserCommand(string Email, string Password) : ICommand<AccessTokenResponse>;
