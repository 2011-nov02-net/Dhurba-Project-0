using System;
using System.Collections.Generic;
namespace Dhurba_Project_0
{
    public class DisplayProduct : IDisplay
    {
        public void FormatAndDisplay(List<Store> storeList)
        {
            foreach (var store in storeList)
            {
                Console.WriteLine($"Id:{store.Id} Name:{store.Name} Location:{store.Location}");
            }
        }

        
    }
}
