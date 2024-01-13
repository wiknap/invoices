using Bogus;
using Bogus.Extensions;

using Invoices.Core.ValueObjects;

namespace Invoices.Core.Tests.Fakers;

public sealed class CompanyDataFaker : Faker<CompanyData>
{
    public CompanyDataFaker()
    {
        CustomInstantiator(f =>
            new CompanyData(
                f.Company.CompanyName().ClampLength(max: 100),
                f.Address.StreetName().ClampLength(max: 100),
                f.Address.BuildingNumber().ClampLength(max: 10),
                f.Address.BuildingNumber().ClampLength(max: 10).OrNull(f),
                f.Address.City().ClampLength(max: 50),
                f.Address.ZipCode().ClampLength(max: 10)
            )
        );
    }
}
