namespace ClassObjectRealations;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string AcademicGroup { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {FirstName} {LastName}, Academic Group: {AcademicGroup}";
    }
}