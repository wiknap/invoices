namespace Invoices.Core.ValueObjects;

public sealed record CompanyData(
    CompanyName Name,
    StreetName StreetName,
    StreetNumber StreetNumber,
    ApartmentNumber? ApartmentNumber,
    City City,
    ZipCode ZipCode);
