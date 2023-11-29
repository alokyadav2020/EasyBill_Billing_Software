﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace BillingSystem.main_class
{
    public static class LocalReportExtensions
    {
        public static void PrintToPrinter(this LocalReport report)
        {
            PageSettings pageSettings = new PageSettings();
            pageSettings.PaperSize = report.GetDefaultPageSettings().PaperSize;            
            pageSettings.Landscape = report.GetDefaultPageSettings().IsLandscape;         
            pageSettings.Margins = report.GetDefaultPageSettings().Margins;
            Print(report, pageSettings);
           
        }

        public static void Print(this LocalReport report, PageSettings pageSettings)
        {
            string deviceInfo =
          
             $@"<DeviceInfo>
                  <OutputFormat>EMF</OutputFormat>
                  <PageWidth>{pageSettings.PaperSize.Width * 100}in</PageWidth>
                  <PageHeight>{pageSettings.PaperSize.Height * 100}in</PageHeight>
                  <MarginTop>{pageSettings.Margins.Top * 100}in</MarginTop>
                  <MarginLeft>{pageSettings.Margins.Left * 100}in</MarginLeft>
                  <MarginRight>{pageSettings.Margins.Right * 100}in</MarginRight>
                  <MarginBottom>{pageSettings.Margins.Bottom * 100}in</MarginBottom>
              </DeviceInfo>";
            Warning[] warnings;
            var streams = new List<Stream>();
            var pageIndex = 0;
            report.Render("Image", deviceInfo,
                (name, fileNameExtension, encoding, mimeType, willSeek) =>
                {
                    MemoryStream stream = new MemoryStream();
                    streams.Add(stream);
                    return stream;
                }, out warnings);
            foreach (Stream stream in streams)
                stream.Position = 0;
            if (streams == null || streams.Count == 0)
                throw new Exception("No stream to print.");
            using (PrintDocument printDocument = new PrintDocument())
            {
                printDocument.DefaultPageSettings = pageSettings;
                if (!printDocument.PrinterSettings.IsValid)
                    throw new Exception("Can't find the default printer.");
                else
                {
                    printDocument.PrintPage += (sender, e) =>
                    {
                        Metafile pageImage = new Metafile(streams[pageIndex]);
                        Rectangle adjustedRect = new Rectangle(e.PageBounds.Left - (int)e.PageSettings.HardMarginX, e.PageBounds.Top - (int)e.PageSettings.HardMarginY, e.PageBounds.Width, e.PageBounds.Height);
                        e.Graphics.FillRectangle(Brushes.White, adjustedRect);
                        e.Graphics.DrawImage(pageImage, adjustedRect);
                        pageIndex++;
                        e.HasMorePages = (pageIndex < streams.Count);
                        e.Graphics.DrawRectangle(Pens.Red, adjustedRect);
                    };
                    printDocument.EndPrint += (Sender, e) =>
                    {
                        if (streams != null)
                        {
                            foreach (Stream stream in streams)
                                stream.Close();
                            streams = null;
                        }
                    };
                    printDocument.Print();
                }
            }
        }
    }
}
