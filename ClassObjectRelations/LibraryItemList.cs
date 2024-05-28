
namespace ClassObjectRealations;

public  abstract  class LibraryItemList<T>
{
    protected List<T> items = new List<T>();

    public void Add(T item) => items.Add(item);

    public void Remove(int id)
    {
        var item = Get(id);
        if (item != null)
        {
            items.Remove(item);
        }
    }

    public void Update(T updatedItem)
    {
        var item = Get(GetId(updatedItem));
        if (item != null)
        {
            items[items.IndexOf(item)] = updatedItem;
        }
    }

    public T Get(int id) => items.FirstOrDefault(item => GetId(item) == id);

    public List<T> GetAll() => items;

    protected abstract int GetId(T item);
}

        
    
    
    
    