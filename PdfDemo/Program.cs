using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;


QuestPDF.Settings.License = LicenseType.Community;


Document.Create(container =>
{
    container.Page(page =>
    {
        page.Size(PageSizes.A4);
        page.Margin(2, Unit.Centimetre);
        page.PageColor(Colors.White);
        page.DefaultTextStyle(x=>x.FontSize(20));

        page.Header()
            .Text("Quest Pdf...")
            .AlignCenter()
            .SemiBold()
            .FontSize(30)
            .FontFamily(Fonts.TimesNewRoman)
            .FontColor(Colors.BlueGrey.Darken1);

        page.Content()
            .PaddingVertical(1, Unit.Centimetre)
            .Column(x =>
            {
                x.Spacing(20);
                x.Item().Text(Placeholders.LoremIpsum()); // it will generate random text
                x.Item().Image(Placeholders.Image(200, 100)); // it will generate random image
            });

        page.Footer()
            .AlignCenter()
            .Text(x =>
            {
                x.Span("Page ");
                x.CurrentPageNumber();
            });

    });
})
    //.ShowInPreviewer()            // it shows the pdf while development
    //.GeneratePdf(@"D:\QuestPdf.pdf")   // it generates the pdf
    .GeneratePdf(@"C:\Users\mustafa maher\Downloads\QuestPdf.pdf")   // it generates the pdf
    ;