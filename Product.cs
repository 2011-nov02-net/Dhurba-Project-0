using System;
namespace Dhurba_Project_0{
	public class Product
{
	string Id{get;}
	public string Name { get; }
	private int _quantity;
	public int Quantity {
		get { return _quantity; }
		set {
			if (value < 0)
			{
				throw new ArgumentException("Product Quantity cant be negative");
			}
             _quantity = value;
			
				}
		}
	public Product(string id,string name,int quantity)
	{
		Id=id;
		Name=name;
		Quantity=quantity;
	}
}

}
