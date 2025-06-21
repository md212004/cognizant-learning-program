// ==========================
// File: ExcelDocument.cs
// Concrete implementation for Excel Document
// ==========================
namespace FactoryMethodPatternExample
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel Document...");
        }
    }
}
