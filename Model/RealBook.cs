namespace NullObjectPattern.Model {
  class RealBook : Book {
    internal RealBook(string title) {
      Title = title;
    }

    internal override string GetTitle() {
      return Title;
    }

    internal override bool IsNull() {
      return false;
    }
  }
}
