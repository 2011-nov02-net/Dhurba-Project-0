using System;

public class Store
{
	
	
    public string Name { get; }
    public string Location { get; }
    public string Id { get; }
    public Store(string id, string name, string location)
    {
        Id = id;
        Location = location;
        Name = name;

    }

}
