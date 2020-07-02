//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Get Your Free API Key: https://app.pdf.co/signup               //
//                                                                                           //
// Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                //
// https://www.bytescout.com                                                                 //
// https://pdf.co                                                                            //
//                                                                                           //
//*******************************************************************************************//


using System.Diagnostics;
using Bytescout.PDF;

namespace ColorProfiles
{
    /// <summary>
    /// This example demonstrates how to use color profiles.
    /// </summary>
    class Program
    {
        static void Main()
        {
            // Create new document
            Document pdfDocument = new Document();
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            // If you wish to load an existing document uncomment the line below and comment the Add page section instead
            // pdfDocument.Load(@".\existing_document.pdf");

            // Add page
            Page page = new Page(PaperFormat.A4);
            pdfDocument.Pages.Add(page);

            // Load ICC color profile
            ICCBasedColorspace iccProfile = new ICCBasedColorspace("USWebCoatedSWOP.icc");
            // Create profiled color brush
            ColorICC iccColor = new ColorICC(iccProfile, new ColorCMYK(0, 100, 0, 0));
            SolidBrush iccBrush = new SolidBrush(iccColor);
            // Draw a circle using the brush
            page.Canvas.DrawCircle(iccBrush, 200, 200, 100);
            
            // Save document to file
            pdfDocument.Save("result.pdf");

            // Cleanup 
            pdfDocument.Dispose();

            // Open result document in default associated application (for demo purpose)
            ProcessStartInfo processStartInfo = new ProcessStartInfo("result.pdf");
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);
        }
    }
}
