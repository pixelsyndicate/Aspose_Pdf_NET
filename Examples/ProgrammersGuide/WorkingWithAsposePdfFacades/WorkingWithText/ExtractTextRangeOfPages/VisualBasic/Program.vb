'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Text

Namespace ExtractTextRangeOfPagesExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'open input PDF
			Dim pdfExtractor As New PdfExtractor()
			pdfExtractor.BindPdf(dataDir & "input.pdf")

			'specify start and end pages
			pdfExtractor.StartPage = 1
			pdfExtractor.EndPage = 1

			'use parameterless ExtractText method
			pdfExtractor.ExtractText()

			Dim tempMemoryStream As New MemoryStream()
			pdfExtractor.GetText(tempMemoryStream)

			Dim text As String = ""
			'specify Unicode encoding type in StreamReader constructor
			Using sr As New StreamReader(tempMemoryStream,Encoding.Unicode)
				sr.BaseStream.Seek(0, SeekOrigin.Begin)
				text = sr.ReadToEnd()
			End Using

			File.WriteAllText(dataDir & "output.txt", text)



		End Sub
	End Class
End Namespace