// ==========================
// File: ExcelFactory.cs
// Factory class to create ExcelDocument
// ==========================
namespace FactoryMethodPatternExample
{
    public class ExcelFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
