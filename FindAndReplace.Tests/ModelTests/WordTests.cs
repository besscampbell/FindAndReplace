using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;
using System;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class WordTests
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