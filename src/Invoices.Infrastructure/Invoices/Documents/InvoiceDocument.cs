using Invoices.Core;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Invoices.Infrastructure.Invoices.Documents;

public sealed class InvoiceDocument : IDocument
{
    private readonly InvoiceData invoiceData;

    public InvoiceDocument(InvoiceData invoiceData)
    {
        this.invoiceData = invoiceData;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Size(PageSizes.A4);
            page.Margin(1, Unit.Centimetre);
            page.MarginHorizontal(2, Unit.Centimetre);
            page.PageColor(Colors.White);

            page.Header().Element(ComposeHeader);
            page.Content().Element(ComposeContent);
            page.Footer().Element(ComposeFooter);
        });
    }

    private void ComposeHeader(IContainer container) => container.Element(ComposeUndeliverableInfo);

    private void ComposeContent(IContainer container)
    {
        container.PaddingVertical(2, Unit.Centimetre)
            .Table(table =>
            {
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(25);
                    columns.RelativeColumn(2);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                });

                // step 2
                table.Header(header =>
                {
                    header.Cell().Element(CellStyle).Text("#");
                    header.Cell().Element(CellStyle).Text("Name");
                    header.Cell().Element(CellStyle).AlignCenter().AlignMiddle().Text("Unit price - Netto");
                    header.Cell().Element(CellStyle).AlignCenter().AlignMiddle().Text("Quantity");
                    header.Cell().Element(CellStyle).AlignCenter().AlignMiddle().Text("Total - Netto");
                    header.Cell().Element(CellStyle).AlignCenter().AlignMiddle().Text("VAT Rate");
                    header.Cell().Element(CellStyle).AlignCenter().AlignMiddle().Text("VAT");
                    header.Cell().Element(CellStyle).AlignCenter().AlignMiddle().Text("Total - Brutto");
                    return;

                    static IContainer CellStyle(IContainer container)
                        => container.DefaultTextStyle(x => x.FontSize(8).SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                });
            });
    }

    private void ComposeFooter(IContainer container) => container.Element(ComposeUndeliverableInfo);

    private void ComposeUndeliverableInfo(IContainer container)
    {
        container.Text(text =>
        {
            text.DefaultTextStyle(s => s.FontSize(6));
            text.Line("If undeliverable, please return to:");
            text.Line(
                $"{invoiceData.Seller.Name} - {invoiceData.Seller.GetFirstAddressLine()} - {invoiceData.Seller.GetSecondAddressLine()}");
        });
    }
}
