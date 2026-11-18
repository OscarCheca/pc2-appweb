namespace pc212053u201621873.Shared.Domain.Model.ValueObjects;

public sealed record LegalityPeriod
{
    public DateOnly StartDate { get; }
    
    public DateOnly EndDate { get; }
    
    private LegalityPeriod()
    {
    }
    
    public LegalityPeriod(DateOnly startDate, DateOnly endDate)
    {
        if (endDate <= startDate)
            throw new ArgumentException("EndDate must be greater than StartDate.", nameof(endDate));

        StartDate = startDate;
        EndDate = endDate;
    }
    
    public bool IsExpired(DateOnly checkDate) => checkDate > EndDate;
}