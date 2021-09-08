using System;
using System.Collections.Generic;
using System.Text;

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
