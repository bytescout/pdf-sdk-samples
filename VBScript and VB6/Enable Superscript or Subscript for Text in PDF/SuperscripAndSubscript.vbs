'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


' This example demonstrates how to create a document and save it to file.

' Create Bytescout.PDF.Document object
Set pdfDocument = CreateObject("Bytescout.PDF.Document")
pdfDocument.RegistrationName = "demo"
pdfDocument.RegistrationKey = "demo"

' If you wish to load an existing document uncomment the line below And comment the Add page section instead
' pdfDocument.Load("existing_document.pdf")

Set comHelpers = pdfDocument.ComHelpers

' Add page
Set page1 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page1)

Set font = comHelpers.CreateSystemFont("Arial", 16)
Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))
Set stringFormat = comHelpers.CreateStringFormat()
xPosition = 20

' Draw normal string
page1.Canvas.DrawString_4 "Normal text ", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Normal text ")

' Draw subscript string 
stringFormat.Rise = -5
page1.Canvas.DrawString_4 "Subscript", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Subscript")

' draw superscript string
stringFormat.Rise = +5
page1.Canvas.DrawString_4 "Superscript", (font), (brush), xPosition, 50, (stringFormat)
xPosition = xPosition + font.GetTextWidth("Superscript")

' Draw the baseline
Set pen = comHelpers.CreateSolidPen(comHelpers.CreateColorRGB(0, 0, 255), 1.0)
pen.Opacity = 50
page1.Canvas.DrawLine (pen), 20, 50 + font.Size, xPosition, 50 + font.Size

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
