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


using System.Diagnostics;
using System.Drawing;
using Bytescout.PDF;

using Brush = Bytescout.PDF.Brush;
using Font = Bytescout.PDF.Font;
using Pen = Bytescout.PDF.Pen;
using SolidBrush = Bytescout.PDF.SolidBrush;
using StringFormat = Bytescout.PDF.StringFormat;

namespace DrawString
{
	/// <summary>
	/// This example demonstrates how to draw a text.
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Create new document
			Document pdfDocument = new Document();
			pdfDocument.RegistrationName = "demo";
			pdfDocument.RegistrationKey = "demo";
			// Add page
			Page page = new Page(PaperFormat.A4);
			pdfDocument.Pages.Add(page);

			// Draw simple text
			Font font = new Font("Arial", 24);
			Brush blackBrush = new SolidBrush();
			page.Canvas.DrawString("Simple text.", font, blackBrush, 20, 20);

			// Draw text with alignment in specified rectangle
			StringFormat stringFormat = new StringFormat();
			stringFormat.HorizontalAlign = HorizontalAlign.Right;
			stringFormat.VerticalAlign = VerticalAlign.Bottom;
			page.Canvas.DrawString("Aligned text", font, blackBrush, new RectangleF(20, 100, 200, 60), stringFormat);
			page.Canvas.DrawRectangle(new SolidPen(), 20, 100, 200, 60);

			// Draw colored text
			Font boldFont = new Font("Arial", 32, true, false, false, false);
			Brush redBrush = new SolidBrush(new ColorRGB(255, 0, 0));
			Pen bluePen = new SolidPen(new ColorRGB(0, 0, 255));
			page.Canvas.DrawString("Colored text", boldFont, redBrush, 20, 200);
			page.Canvas.DrawString("Outlined colored text", boldFont, redBrush, bluePen, 20, 240);
			page.Canvas.DrawString("Outlined transparent text", boldFont, bluePen, 20, 280);
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
