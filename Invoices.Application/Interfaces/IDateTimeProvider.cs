namespace Invoices.Application.Interfaces;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
    DateOnly DateOnlyUtcNow => DateOnly.FromDateTime(UtcNow);
    TimeOnly TimeOnlyUtcNow => TimeOnly.FromDateTime(UtcNow);
}