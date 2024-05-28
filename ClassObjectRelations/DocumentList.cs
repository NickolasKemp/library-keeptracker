   
namespace ClassObjectRealations;

public class DocumentList : LibraryItemList<Document>
{
    protected override int GetId(Document document) => document.Id;
}

        
    
    
    
    