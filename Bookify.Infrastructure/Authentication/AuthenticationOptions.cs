namespace Bookify.Infrastructure.Authentication;

public sealed class AuthenticationOptions
{
    public string Audience { get; init; } = String.Empty;
    public string MetadataUrl { get; init; } = String.Empty;
    public bool RequireHttpsMetadata { get; init; }
    public string ValidIssuer { get; set; } = String.Empty;
}
