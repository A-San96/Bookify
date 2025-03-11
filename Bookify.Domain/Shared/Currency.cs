namespace Bookify.Domain.Shared;

public record Currency
{
    public static Currency Usd { get; } = new("USD");
    public static Currency Eur { get; } = new("EUR");
    public static Currency None { get; } = new("");

    private Currency(string code) => Code = code;

    public string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code == code)
            ?? throw new ApplicationException($"The Currency with code {code} is invalid");
    }

    public static readonly IReadOnlyCollection<Currency> All = [Usd, Eur];
}
