namespace GraphQlServer;

public class Query
{
    public IList<Entity> GetEntities() =>
        new List<Entity>()
        {
            new Entity
            {
                Id = "first",
                Name = "FIRST ENTITY",
                NestedObjects = new List<NestedObject>()
                {
                    new NestedObject()
                    {
                        Id = "delivery-1",
                        Name = "firstNested"
                    }
                }
            },
            new Entity
            {
                Id = "second",
                Name = "SECOND ENTITY",
                NestedObjects = new List<NestedObject>()
                {
                    new NestedObject()
                    {
                        Id = "delivery-1",
                        Name = "secondNested"
                    }
                }
            }
        };
}