namespace pc212053u201621873.Shared.Domain.Model.ValueObjects;

public sealed record MonetaryAmount
{
   
    public decimal Value { get; }
    
    public string Currency { get; }

  
    private MonetaryAmount()
    {
        Currency = string.Empty;
    }
    
    public MonetaryAmount(decimal value, string currency)
    {
        if (value < decimal.Zero)
            throw new ArgumentOutOfRangeException(nameof(value), value, "Monetary amount value must be greater than or equal to decimal.Zero.");

        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentNullException(nameof(currency), "Monetary amount currency cannot be null or blank.");

        Value = value;
        Currency = currency.Trim().ToUpperInvariant();
    }

  
    public MonetaryAmount Multiply(decimal factor)
    {
        if (factor < decimal.Zero)
            throw new ArgumentOutOfRangeException(nameof(factor), factor, "Multiplication factor cannot be negative.");

        return new MonetaryAmount(Value * factor, Currency);
    }
    
    public static MonetaryAmount operator *(MonetaryAmount amount, decimal factor) => amount.Multiply(factor);
}