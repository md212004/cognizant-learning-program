// ==========================
// File: DocumentFactory.cs
// Abstract factory class with a method to create documents
// ==========================
namespace FactoryMethodPatternExample
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();
    }
}
