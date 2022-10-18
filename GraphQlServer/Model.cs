namespace GraphQlServer;

public class Entity
{
    public string Id { get; set; }
    public string Name { get; set; }
    public IList<NestedObject> NestedObjects { get; set; }
}

public class NestedObject
{
    public string Id { get; set; }
    public string Name { get; set; }
}