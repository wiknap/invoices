using Invoices.Core;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Invoices.Infrastructure.Invoices.Documents;

public class InvoiceDocument : IDocument
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
        container.PaddingVertical(2, Unit.Centimetre);
            // .Grid(grid =>
            // {
            //     grid.Columns(2);
            //     grid.Item().Text(text => { text.Line("Line"); });
            //     grid.Item().AlignRight().Text(text => { text.Line("Line"); });
            //     grid.Item(2).AlignRight().Text(text => { text.Line("Line"); });
            //     grid.Item(2).Text(text => { text.Line("Line"); });
            // });
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
