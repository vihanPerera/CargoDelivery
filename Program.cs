using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System.Data.Common;
using PdfDocument = QuestPDF.Fluent.Document;

QuestPDF.Settings.License = LicenseType.Community;

var fileName = "Goods-reveived-note.pdf";

PdfDocument.Create(container =>
{
    container.Page(page =>
    {
        page.Size(PageSizes.A4.Portrait());
        page.Margin(1, Unit.Centimetre);
        page.PageColor(Colors.White);
        page.DefaultTextStyle(x => x.FontSize(10));

        page.Content()
            .Element(PageBorder)
            .PaddingVertical(1, Unit.Centimetre)
            .Column(x =>
            {
                x.Spacing(10);

                x.Item().Row(row =>
                {
                    row.RelativeItem().PaddingLeft(10).Column(columnLeft =>
                    {
                        columnLeft.Item().Text("EXPOLANKA FREIGHT (PVT) LIMITED")
                            .Bold()
                            .FontSize(10);

                        columnLeft.Item().Text("No 390, Avissawella Road")
                            .FontSize(9);

                        columnLeft.Item().Text("Wellampitiya 10600")
                            .FontSize(9);

                        columnLeft.Item().Text("Phone - +94 11479 1000")
                            .FontSize(9);

                        columnLeft.Item().Text("E - LKA-Info@efl.global | W - www.efl.global")
                            .FontSize(9);
                        columnLeft.Item().Text("VAT Reg No: 104083536-7000 | SVAT Reg No: SVAT000408 | Business Reg No: PV-2336")
                            .FontSize(8);
                    });

                    row.ConstantItem(100).PaddingLeft(10).Height(65).Image("EFL.png");
                });

                x.Item().AlignCenter().Text("GOODS RECEIVED NOTE – B00134268").Underline().FontColor("#333333").FontSize(12).ExtraBold();
                

                x.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.ConstantColumn(240);
                        columns.ConstantColumn(244);
                        columns.ConstantColumn(25);
                    });

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("CONSIGNEE").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("FITS RETAIL (PVT) LTD").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("Job Number").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("B00181030").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("CARTONS").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("2 PKG").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("NET MASS (KG)").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("50 KG").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("MARKS & NO").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text =>
                    {
                        text.Line("EIL/20240929").FontSize(9).Bold();
                        text.EmptyLine();
                        text.Line("17696604782").FontSize(9).Bold();
                    });
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("VEHICLE NO").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text("");
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("ENTRY NO").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("I-25786").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("CONDITION OF THE GOODS").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("GOOD").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("EXPORTER").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("NUOVA RICAMBI SRL").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("LOCATION").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("WELLAMPITIYA 10600").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("SEAL NO").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithBorders).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(9).Bold());
                });

                //x.Item().Row(row =>
                //{
                //    row.RelativeItem().PaddingLeft(25).Column(columnLeft =>
                //    {
                //        columnLeft.Item().Text("")
                //            .Bold()
                //            .FontSize(10);
                //    });

                //    row.ConstantItem(200).Height(50).Image("EFL.png");

                //    row.ConstantItem(80).Column(columnLeft =>
                //    {
                //        columnLeft.Item().Text("")
                //            .Bold()
                //            .FontSize(10);
                //    });

                //    row.ConstantItem(200).Column(columnLeft =>
                //    {
                //        columnLeft.Item().Text("Factory In Time")
                //            .Bold()
                //            .FontSize(10);

                //        columnLeft.Item().Text("")
                //            .FontSize(9);

                //        columnLeft.Item().Text("")
                //           .FontSize(9);

                //        columnLeft.Item().Text("Factory Out Time")
                //            .FontSize(9);
                //    });
                //});

                x.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.ConstantColumn(200);
                        columns.ConstantColumn(80);
                        columns.ConstantColumn(200);
                        columns.ConstantColumn(25);
                    });

                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(11).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("Filled by EFL").FontSize(11).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(11).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("Filled by Customer").FontSize(11).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Text(text => text.Span("").FontSize(11).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderSpecialStyle2).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    // table.Cell().Element(CellStyleWithoutBorders).Height(50).Image("Signature.png");
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderSpecialStyle2).Container().Height(15).Text(text => text.Span("Factory In Time").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderSpecialStyle).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderSpecialStyle).Container().Height(15).Text(text => text.Span("Factory Out Time").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderSpecialStyle).Container().Height(15).Text(text => text.Span("Authorized person Name").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderSpecialStyle).Container().Height(15).Text(text => text.Span("Receiver Signature with Seal").FontSize(9).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderSpecialStyle).Container().Height(15).Text(text => text.Span("Authorize person signature").FontSize(9).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderSpecialStyle).Container().Height(15).Text(text => text.Span("Receiver Name").FontSize(9).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());

                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderStyleWithBorderLeft).Container().Height(15).Text(text => text.Span("Date & Time").FontSize(9).ExtraBold());
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                    table.Cell().Element(HeaderStyleWithBorderRight).Container().Height(15).Text(text => text.Span("Received Date & Time").FontSize(9).Bold());
                    table.Cell().Element(CellStyleWithoutBorders).Container().Height(15).Text(text => text.Span("").FontSize(9).Bold());
                });


                x.Item().AlignCenter().Text("Please do contact below personels if there is any discrepencies on this shipment").FontColor("#000000").FontSize(9).Bold();

                x.Item().AlignLeft().PaddingLeft(28).Text("Fazal Bisthami 777751784").FontColor("#000000").FontSize(9).Bold();
                x.Item().AlignLeft().PaddingLeft(28).Text("Chanuka Janith 773980683").FontColor("#000000").FontSize(9).Bold();

                x.Item().AlignCenter().Text("#390, Avissawella Road , Wellampitiya, Sri Lanka\r\nTel +94 (11) 4791000, 4335573 Fax +94 (11) 2574213, 2576725 Web www.expolankafreight.com").FontColor("#000000").FontSize(9).Bold();
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
.ShowInPreviewer();

IContainer CellStyleWithBorders(IContainer container)
{
    return container
        .Border(1)
        .BorderColor("#000000")
        .PaddingVertical(3)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer CellStyleWithoutBorders(IContainer container)
{
    return container
      
        .PaddingVertical(3)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer HeaderStyleWithBorderLeft(IContainer container)
{
    return container
        .BorderLeft(1)
        .BorderRight(1)
        .BorderBottom(1)
        .BorderColor("#000000")
        .PaddingVertical(3)
        .PaddingBottom(10)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer HeaderStyleWithBorderRight(IContainer container)
{
    return container
        .BorderRight(1)
        .BorderLeft(1)
        .BorderBottom(1)
        .BorderColor("#000000")
        .PaddingVertical(4)
        .PaddingBottom(10)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer HeaderSpecialStyle(IContainer container)
{
    return container
        .BorderRight(1)
        .BorderLeft(1)
        .BorderColor("#000000")
        .PaddingVertical(4)
        .PaddingBottom(10)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer HeaderSpecialStyle2(IContainer container)
{
    return container
        .BorderTop(1)
        .BorderRight(1)
        .BorderLeft(1)
        .BorderColor("#000000")
        .PaddingVertical(4)
        .PaddingBottom(10)
        .PaddingHorizontal(5)
        .AlignLeft();
}

IContainer PageBorder(IContainer container)
{
    return container
        .Padding(2);
}
