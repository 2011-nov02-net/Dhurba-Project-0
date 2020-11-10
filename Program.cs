using System;
using System.Collections.Generic;

namespace Dhurba_Project_0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back to Dhurba Grocery Store, Are you John, Matt, Jessica or Shayam");
            string customerName = Console.ReadLine();
            Console.WriteLine($"Welcome {customerName}, Nice to see u again. Please choose one of the store (1,2 or 3) that you would like to shop from");
            // display list of store and ask to choose one
            List<Store> storeList = allStore();
            //creating an object of class DisplayProduct
            DisplayProduct myDisplayProduct = new DisplayProduct();
            //calling method of DisplayProduct to display list of store
            myDisplayProduct.FormatAndDisplay(storeList);
            //customer choice of store
            string storeNumber=Console.ReadLine();
            //display items from list
            List<Product>desiredProduct=allProduct();


        }
        static List<Store> allStore()
        {
            return new List<Store>{
            new Store("1","Store1","Blacklick"),
            new Store("2","Store2","Reynoldsburg" ),
            new Store("3", "Store3","Westerville")
            };
        }
        static List<Product>allProduct(){
            return new List<Product>{
                new Product("1","Orange",100),
                new Product("2","Apple",100),
                new Product("3","Mango",100)
            };
        }
       /* static Dictionary<Store,List<Product>>allProduct(){
           return List<Product>productList= new List<Product>{
                new Product("1","Orange",100),
                new Product("2","Apple",100),
                new Product("3","Mango",100)
           };
           myDictionary.Add("1",new List<Product>{new Product("1","Orange",100),new Product("2","Apple",100),new Product("3","Mango",100)});
            myDictionary .Add(2,new List<Product>{new Product("1","Orange",100),new Product("2","Apple",100),new Product("3","Mango",100)});
            myDictionary.Add(3,new List<Product>{new Product("1","Orange",100), new Product("2","Apple",100), new Product("3","Mango",100)});
           
           return myDictionary;
           */

          /* {
                new Product("1","Orange",100),
                new Product("2","Apple",100),
                new Product("3","Mango",100)
            };
           */
            
        }


    }

