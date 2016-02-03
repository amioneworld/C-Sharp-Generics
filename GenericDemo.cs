using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

public  interface IGenerics
{
     void DisplayName(string name);
}


public class GenericDemo : IGenerics
{
   public static void Main(string[] args)
   {
       Console.WriteLine("Generics Demo");
   
    GenericDemo generic = new GenericDemo();
       
     /*
       var ItemList = new List<string>() {"First","Second","Third","Fourth"};
       
       
       
       
       foreach(var item in ItemList)
       {
          generic.DisplayName(item);
       }
    */
       
    var accounts =   generic.GetAccounts();
       
       
     
       foreach(var account in accounts)
       {
           Console.WriteLine ( $"Id= {account.Value.Id} of Name: {account.Value.Name} is {account.Value.IsActive}" );
       }
       
      
   }

   public  void  DisplayName(string name) {
       Console.WriteLine( $"Item Name is {name}");
   }
  
       
      
  public Dictionary<int,Account> GetAccounts()
  {
      var accounts = new Dictionary<int, Account>()
      {
          {1, new Account(1,"Amit",true)},
          {2, new Account(2,"Dave",false)}
      };
      
      return accounts;
  }
    
    
    
    
  public class Account
  {
      public Account(int id, string name, bool isActive)
      {
          this.Id = id;
          this.Name = name;
          this.IsActive = isActive;
      }
      
      
      public int Id {get;set;}
      public string Name {get; set;}
      public bool IsActive {get; set;}
  }
    
    
    
}

// Included Url to run and test the above code at coderpad.io
