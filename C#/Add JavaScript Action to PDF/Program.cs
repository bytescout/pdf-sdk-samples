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

namespace JavaScriptActionExample
{
    /// <summary>
    /// This example demonstrates how to add JavaScript actions to document events.
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
            pdfDocument.Pages.Add(new Page(PaperFormat.A4));

            // Add action to document open event
            JavaScriptAction onOpenDocument = new JavaScriptAction("app.alert(\"OnOpenDocument\",3)");
            pdfDocument.OnOpenDocument = onOpenDocument;

            // Add action to document close event
            JavaScriptAction onBeforeClosing = new JavaScriptAction("app.alert(\"OnBeforeClosing\",3)");
            pdfDocument.OnBeforeClosing = onBeforeClosing;
            
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
