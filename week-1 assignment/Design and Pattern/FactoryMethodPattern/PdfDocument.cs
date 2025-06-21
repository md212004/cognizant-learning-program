// ==========================
// File: PdfDocument.cs
// Concrete implementation for PDF Document
// ==========================
namespace FactoryMethodPatternExample
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document...");
        }
    }
}
