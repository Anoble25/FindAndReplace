using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class FindAndReplaceTest
  {
    [TestMethod]
    public void HelloWorldToUniverse_Return_HelloUniverse()
    {
      FindAndReplace testFindAndReplace = new FindAndReplace();
      Assert.AreEqual("Hello universe", testFindAndReplace.PerformStringReplacement("Hello world", "world", "universe"));
    }

    [TestMethod]
    public void SecondString_Return_SecondStringWithWordReplaced()
    {
      FindAndReplace testFindAndReplace = new FindAndReplace();
      Assert.AreEqual("Today, I will eat lunch early in the day", testFindAndReplace.PerformStringReplacement("Today, I will eat dinner early in the day", "dinner", "lunch"));
    }

  }
}
