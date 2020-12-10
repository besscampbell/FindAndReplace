using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class Word
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      string sentence = "The mountains are behind the clouds today";
      string oldWord = "clouds";
      string newWord = "houses";

      Word myPhrase = new Word(sentence, oldWord, newWord);
    }

  }
}