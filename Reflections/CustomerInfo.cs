using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class CustomerInfo
    {
        public int Id
        {
            get; set;
        }
        public string Name 
        { 
            get; set; 
        }
        public bool IsDeleted { get; set; }

        public CustomerInfo(int id, string name,bool isDeleted)
        {
            this.Id = id;
            this.Name = name;
            this.IsDeleted = isDeleted;
        }
        public CustomerInfo() 
        {
            this.Id = 1;
            this.Name= string.Empty;
            this.IsDeleted = false;
        }
        public void PrintID()
        {
            Console.WriteLine("ID is :{0}",this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name is:{0}",this.Name);
        }
        public void PrintValue() 
        {
            Console.WriteLine("Deleted Value is :{0}",this.IsDeleted);
        }

    }
}
