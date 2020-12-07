using System;
using System.Collections.Generic;
namespace dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();    
            AuthorList.Add("Mahesh Chand", 35);    
            AuthorList.Add("Mike Gold", 25);    
            AuthorList.Add("Praveen Kumar", 29);    
            AuthorList.Add("Raj Beniwal", 21);    
            AuthorList.Add("Dinesh Beniwal", 84);    
   
            Console.WriteLine("Count: {0}", AuthorList.Count);    
   
            AuthorList["Neel Beniwal"] = 9;    
            if (!AuthorList.ContainsKey("Mahesh Chand"))    
            {    
                AuthorList["Mahesh Chand"] = 20;    
            }    
            if (!AuthorList.ContainsValue(9))    
            {    
                Console.WriteLine("Item found");    
            }    
                
             
            Console.WriteLine("Authors all items:");    
            foreach (KeyValuePair<string, Int16> author in AuthorList)    
            {    
                Console.WriteLine("Key: {0}, Value: {1}",    
                author.Key, author.Value);    
            }    
            
            AuthorList.Remove("Mahesh Chand");    
            
            AuthorList.Clear(); 
        }
    }
}
