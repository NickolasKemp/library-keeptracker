namespace ClassObjectRealations;

public class Document
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsIssued { get; set; }
    public int? IssuedToUserId { get; set; }
    
    public override string ToString()
    {
        return $"ID: {Id}, Title: {Title}, Author: {Author}, IsIssued: {IsIssued}, IssuedToUser: {(IsIssued ? IssuedToUserId.ToString() : "empty")}" ;
    }
}

        
    
    
    
    