//*******************************************************************************************//
//                                                                                           //
// Download Free Evaluation Version From: https://bytescout.com/download/web-installer       //
//                                                                                           //
// Also available as Web API! Free Trial Sign Up: https://secure.bytescout.com/users/sign_up //
//                                                                                           //
// Copyright © 2017-2018 ByteScout Inc. All rights reserved.                                 //
// http://www.bytescout.com                                                                  //
//                                                                                           //
//*******************************************************************************************//


using Bytescout.PDF;
using System;

namespace RemovePdfProtection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Files
                string fileName = "ProtectedPDFFile.pdf";
                string fileName_UnProtected = "UnProtectedPDFFile.pdf";

                //Protected file password
                string filePassword = "admin@123";

                //Process file to remove password
                using (Document document = new Document())
                {
                    document.RegistrationName = "demo";
                    document.RegistrationKey = "demo";

                    document.Load(fileName, filePassword);

                    // Remove password protection and encryption
                    document.Security.OwnerPassword = String.Empty;
                    document.Security.UserPassword = String.Empty;
                    document.Security.EncryptionAlgorithm = EncryptionAlgorithm.None;

                    // Remove restrictions
                    document.Security.AllowAccessibilitySupport = true;
                    document.Security.AllowAssemlyDocument = true;
                    document.Security.AllowContentExtraction = true;
                    document.Security.AllowFillForms = true;
                    document.Security.AllowModifyAnnotations = true;
                    document.Security.AllowModifyDocument = true;
                    document.Security.AllowPrintDocument = true;
                    document.Security.PrintQuality = PrintQuality.HightResolution;

                    //Save Unprotected file
                    document.Save(fileName_UnProtected);
                }

                Console.WriteLine("PDF restrictions removed successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();
        }
    }
}
