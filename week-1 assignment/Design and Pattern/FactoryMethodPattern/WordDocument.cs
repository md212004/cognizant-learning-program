// ==========================
// File: WordDocument.cs
// Concrete implementation for Word Document
// ==========================
namespace FactoryMethodPatternExample
{
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Word Document...");
        }
    }
}
