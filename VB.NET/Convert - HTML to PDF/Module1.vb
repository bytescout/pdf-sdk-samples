'*****************************************************************************************'
'                                                                                         '
' Download offline evaluation version (DLL): https://bytescout.com/download/web-installer '
'                                                                                         '
' Signup Web API free trial: https://secure.bytescout.com/users/sign_up                   '
'                                                                                         '
' Copyright © 2017-2018 ByteScout Inc. All rights reserved.                               '
' http://www.bytescout.com                                                                '
'                                                                                         '
'*****************************************************************************************'


Imports System.Drawing.Printing
Imports Bytescout.PDF.Converters

Module Module1

    <STAThread>
    Sub Main()

		Using converter As New HtmlToPdfConverter()

			converter.PageSize = PaperKind.A4
			converter.Orientation = PaperOrientation.Portrait
			converter.Footer = "<p style=""color: blue;"">FOOTER TEXT</p>"

			converter.ConvertHtmlToPdf("sample.html", "result.pdf")
			
			' You can also pass a link instead of the input file:  
			'converter.ConvertHtmlToPdf("http://google.com", "result.pdf")

		End Using

		' Open result file in default PDF viewer
		Process.Start("result.pdf")

    End Sub

End Module
