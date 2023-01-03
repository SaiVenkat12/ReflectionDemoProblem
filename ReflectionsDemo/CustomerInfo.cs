using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsDemo
{
    internal class CustomerInfo
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public CustomerInfo(int id,string name) 
        {
            this.Id = id;
            this.Name = name;
        }
        public CustomerInfo() 
        {
            this.Id=-1;
            this.Name = "abcd";
        }
        public void operate()
        {
            Console.WriteLine("Name is:" + this.Name);
        }
    }
}
