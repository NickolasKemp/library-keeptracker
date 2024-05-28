namespace ClassObjectRealations;

public class SortingService
{
    public List<User> SortUsersByFirstName(List<User> users)
    {
        return users.OrderBy(user => user.FirstName).ToList();
    }

    public List<User> SortUsersByLastName(List<User> users)
    {
        return users.OrderBy(user => user.LastName).ToList();
    }

    public List<User> SortUsersByAcademicGroup(List<User> users)
    {
        return users.OrderBy(user => user.AcademicGroup).ToList();
    }
    
    public List<Document> SortDocumentsByTitle(List<Document> documents)
    {
        return documents.OrderBy(document => document.Title).ToList();
    }

    public List<Document> SortDocumentsByAuthor(List<Document> documents)
    {
        return documents.OrderBy(document => document.Author).ToList();
    }
}
