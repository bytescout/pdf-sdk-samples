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


' This example demonstrates how to create a button with GoTo action.

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
Set page2 = comHelpers.CreatePage(comHelpers.PAPERFORMAT_A4)
pdfDocument.Pages.Add(page2)

Set timesFont = comHelpers.CreateStandardFont(comHelpers.STANDARDFONTS_TIMES, 18)
Set blackBrush = comHelpers.CreateSolidBrush(comHelpers.CreateColorGray(0))

' Mark action target with text
page2.Canvas.DrawString "Action target", (timesFont), (blackBrush), 20, 200

' Create button
Set button1 = comHelpers.CreatePushButton(20, 20, 100, 25, "button1")
button1.Caption = "Go To Page 2"

' Create action to go to page 2 at 200 points from the top
button1.OnActivated = comHelpers.CreateGoToAction(comHelpers.CreateDestination((page2), 200))

page1.Annotations.Add(button1)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
