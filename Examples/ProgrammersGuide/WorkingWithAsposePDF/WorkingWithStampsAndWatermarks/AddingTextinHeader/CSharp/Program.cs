//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace AddingTextinHeader
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir+ "input.pdf");

            //create header
            TextStamp textStamp = new TextStamp("Header Text");
            //set properties of the stamp
            textStamp.TopMargin = 10;
            textStamp.HorizontalAlignment = HorizontalAlignment.Center;
            textStamp.VerticalAlignment = VerticalAlignment.Top;
            //add header on all pages
            foreach (Page page in pdfDocument.Pages)
            {
                page.AddStamp(textStamp);
            }

            //save updated document
            pdfDocument.Save(dataDir+ "output.pdf");
 
            
            
        }
    }
}