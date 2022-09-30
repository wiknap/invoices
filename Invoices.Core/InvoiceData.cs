namespace Invoices.Core;

public record InvoiceData(CompanyInfo Seller, CompanyInfo Buyer);

public record CompanyInfo(string Name, string StreetName, string StreetNumber, string? ApartmentNumber, string City,
    string PostalCode);

public static class InvoiceDataExtension
{
    public static string GetFirstAddressLine(this CompanyInfo data)
    {
        var line = $"{data.StreetName} ${data.StreetNumber}";
        return data.ApartmentNumber is not null ? $"{line}/{data.ApartmentNumber}" : line;
    }

    public static string GetSecondAddressLine(this CompanyInfo data) => $"{data.PostalCode}, ${data.City}";
}