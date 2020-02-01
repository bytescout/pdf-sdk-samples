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


using Bytescout.PDF;
using System;

namespace ReadForm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load PDF form
            Document pdfDocument = new Document(@"W-9_Filled.pdf");
            pdfDocument.RegistrationName = "demo";
            pdfDocument.RegistrationKey = "demo";

            Page page = pdfDocument.Pages[0];

            Console.WriteLine("W-9 Form values are as follows");

            // Name
            var cName = ((EditBox)page.Annotations["f1_1[0]"]).Text;
            Console.WriteLine($"Name: {cName}");

            // Business Address
            var cAddress = ((EditBox)page.Annotations["f1_2[0]"]).Text;
            Console.WriteLine($"Address: {cAddress}");

            // Cleanup 
            pdfDocument.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();
        }
    }
}
