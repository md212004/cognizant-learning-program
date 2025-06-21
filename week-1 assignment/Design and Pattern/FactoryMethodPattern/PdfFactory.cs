// ==========================
// File: PdfFactory.cs
// Factory class to create PdfDocument
// ==========================
namespace FactoryMethodPatternExample
{
    public class PdfFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
