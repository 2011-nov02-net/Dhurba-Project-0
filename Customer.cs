using System;
namespace Dhurba_Project_0{
	public class Customer
{	
	string Id { get; }
	public string FirstName { get; }
	public string LastName { get; }

	public Customer(string id,string firstname,string lastname)
	{
		Id = id;
		FirstName = firstname;
		LastName = lastname;
	}

	
}

}


