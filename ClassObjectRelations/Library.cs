
namespace ClassObjectRealations;

public class Library
{
    private UserList userList = new UserList();
    private DocumentList documentList = new DocumentList();

    private SortingService sortingService = new SortingService();

    private SearchService searchService = new SearchService();
    // User management
    public void AddUser(User user) => userList.Add(user);
    public void RemoveUser(int userId) => userList.Remove(userId);
    public void UpdateUser(User updatedUser) => userList.Update(updatedUser);
    public User GetUser(int userId) => userList.Get(userId);
    public List<User> GetAllUsers() => userList.GetAll();

    // Document management
    public void AddDocument(Document document) => documentList.Add(document);
    public void RemoveDocument(int documentId) => documentList.Remove(documentId);
    public void UpdateDocument(Document updatedDocument) => documentList.Update(updatedDocument);
    public Document GetDocument(int documentId) => documentList.Get(documentId);
    public List<Document> GetAllDocuments() => documentList.GetAll();

    // Issuing documents
    public bool IssueDocument(int documentId, int userId)
    {
        //Todo: wrap into try catch and add exeption

        var document = documentList.Get(documentId);
        if (document != null && !document.IsIssued && GetDocumentsByUser(userId).Count < 5)
        {
            document.IsIssued = true;
            document.IssuedToUserId = userId;
            return true;
        }
        return false;
    }

    public bool ReturnDocument(int documentId)
    {
        var document = documentList.Get(documentId);
        if (document != null && document.IsIssued)
        {
            document.IsIssued = false;
            document.IssuedToUserId = null;
            return true;
        }

        return false;
    }

    public List<Document> GetDocumentsByUser(int userId) =>
        documentList.GetAll().Where(d => d.IssuedToUserId == userId).ToList();

    public User GetDocumentHolder(int documentId)
    {
        var document = documentList.Get(documentId);
        return document != null && document.IsIssued ? userList.Get(document.IssuedToUserId.Value) : null;
    }
    
    public List<Document> SearchDocuments(string keyword) =>
        searchService.SearchDocumentsByKeyword(documentList.GetAll(), keyword);
    public List<User> SearchUsers(string keyword) => searchService.SearchUsersByKeyword(userList.GetAll(), keyword);
    
    public List<User> SortUsersByFirstName() => sortingService.SortUsersByFirstName(userList.GetAll());
    public List<User> SortUsersByLastName() => sortingService.SortUsersByLastName(userList.GetAll());
    public List<User> SortUsersByAcademicGroup() => sortingService.SortUsersByAcademicGroup(userList.GetAll());
    public List<Document> SortDocumentsByTitle() => sortingService.SortDocumentsByTitle(documentList.GetAll());
    public List<Document> SortDocumentsByAuthor() => sortingService.SortDocumentsByAuthor(documentList.GetAll());
}