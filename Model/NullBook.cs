namespace NullObjectPattern.Model {
  class NullBook : Book {
    internal NullBook() { }

    internal override string GetTitle() {
      return "Not exist in database";
    }

    internal override bool IsNull() {
      return true;
    }
  }
}
