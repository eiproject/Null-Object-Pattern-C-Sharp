using NullObjectPattern.Model;

namespace NullObjectPattern {
  class Bookfactory {
    private string[] _availableTitle = new string[] { "A", "B", "D" };
    internal Bookfactory() { }

    public Book GetCustomer(string title) {
      foreach (string t in _availableTitle) {
        if (t == title) {
          return new RealBook(title);
        }
      }
      return new NullBook();
    }
  }
}
