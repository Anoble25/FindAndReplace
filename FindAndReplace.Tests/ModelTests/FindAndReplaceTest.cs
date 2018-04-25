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

  }
}
