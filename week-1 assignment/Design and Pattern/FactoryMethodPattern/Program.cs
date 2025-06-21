// ==========================
// File: Program.cs
// Entry point that tests the Factory Method pattern
// ==========================
using System;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Word Document
            DocumentFactory wordFactory = new WordFactory();
            IDocument word = wordFactory.CreateDocument();
            word.Open();

            // Create a PDF Document
            DocumentFactory pdfFactory = new PdfFactory();
            IDocument pdf = pdfFactory.CreateDocument();
            pdf.Open();

            // Create an Excel Document
            DocumentFactory excelFactory = new ExcelFactory();
            IDocument excel = excelFactory.CreateDocument();
            excel.Open();
        }
    }
}
