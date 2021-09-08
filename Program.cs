using NullObjectPattern.Model;
using System;

namespace NullObjectPattern {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Null Object Pattern!");
      Bookfactory factory = new Bookfactory();
      
      Book a = factory.GetCustomer("A");
      Book b = factory.GetCustomer("B");
      Book c = factory.GetCustomer("C");
      Book d = factory.GetCustomer("D");
      Book e = factory.GetCustomer("E");

      Console.WriteLine(a.GetTitle());
      Console.WriteLine(b.GetTitle());
      Console.WriteLine(c.GetTitle());
      Console.WriteLine(d.GetTitle());
      Console.WriteLine(e.GetTitle());
    }
  }
}
