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


' This example demonstrates how to use fonts.

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

Set canvas = page1.Canvas

Set brush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Use standard PDF font
Set standardFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 16)
canvas.DrawString "Standard font.", (standardFont), (brush), 20, 20

' Use font installed in system
Set systemFont = comHelpers.CreateSystemFont("Arial", 16)
canvas.DrawString "Windows font.", (systemFont), (brush), 20, 50

' Use font loaded from file
Set fontFromFile = comHelpers.LoadFontFromFile("VeraBI.ttf", 16)
canvas.DrawString "Font loaded from file.", (fontFromFile), (brush), 20, 80

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
