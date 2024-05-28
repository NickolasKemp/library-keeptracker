namespace ClassObjectRealations;

public class UserList : LibraryItemList<User>
{
    protected override int GetId(User user) => user.Id;
}

        
    
    
    
    