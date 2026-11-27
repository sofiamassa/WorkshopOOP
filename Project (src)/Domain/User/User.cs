using System;
using System.Collections.Generic;

public abstract class User
{
    public string ID { get; set; }

    public User(string id)
    {
        ID = id;
    }

    public abstract string GetRole();
}

public class Employer : User
{
    public Employee(string id) : base(id) { }
   
    public override string GetRole();
    {
        return "Employee";
    }

    public void ManageCollection()
    {
    }

    public void AddItem();
    {
    }

    public void RemoveItem();
    {
    }
}

public class Admin : User
{
    public Admin(string id) : base(id)
    {
    }
    
        public override string GetRole()
        {
            return "Admin";
        }
    
        public void ManageCollection() 
        { 
        }
    
        public void AddItem() 
        {
        }
    
        public void RemoveItem()
        {
        }
    
        public void ViewUser() 
        {
        }
    
        public User CreateUser()
        {
            return null;
        }
    
        public void DeleteUser() 
        { 
        }
}
  
public class Member : User
{
    public Member(string id) : base(id) { }

    public override string GetRole()
    {
        return "Member";
    }

    public List<string> ListItemsType()
    {
        return new List<string>
        {
        }
    }

    public string PreviewDetails()
    {
    }
    
    public void AccessMedia()
    {
    }
}