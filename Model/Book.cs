namespace NullObjectPattern.Model {
  abstract class Book {
    protected string Title;
    internal abstract bool IsNull();
    internal abstract string GetTitle();
  }
}
