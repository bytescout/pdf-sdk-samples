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


' This example demonstrates how to add a text annotation.

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

' Add collapsed annotation (shown as a tooltip when mouse is over the icon)
Set collapsedAnnotation = comHelpers.CreateTextAnnotation(20, 20)
collapsedAnnotation.Color = comHelpers.CreateColorRGB(255, 255, 0)
collapsedAnnotation.Icon = comHelpers.TEXTANNOTATIONICON_COMMENT
collapsedAnnotation.Author = "Mr. Important"
collapsedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
page1.Annotations.Add(collapsedAnnotation)

' Add expanded annotation
Set expandedAnnotation = comHelpers.CreateTextAnnotation(20, 50)
expandedAnnotation.Color = comHelpers.CreateColorRGB(255, 0, 0)
expandedAnnotation.Icon = comHelpers.TEXTANNOTATIONICON_NOTE
expandedAnnotation.Open = True
expandedAnnotation.Author = "John Doe"
expandedAnnotation.Contents = "The quick brown fox jumps over the lazy dog."
page1.Annotations.Add(expandedAnnotation)

' Save document to file
pdfDocument.Save("result.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "result.pdf", 1, false
