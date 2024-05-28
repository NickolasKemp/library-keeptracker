namespace ClassObjectRealations;

public class SearchService
{
    public List<User> SearchUsersByKeyword(List<User> users, string keyword)
    {
        return users.Where(u => u.FirstName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                u.LastName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
    
    public List<Document> SearchDocumentsByKeyword(List<Document> documents, string keyword)
    {
        return documents.Where(d => d.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                    d.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}