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

    [TestMethod]
    public void WordReplace_ReplacesWord_String()
    {
      //Arrange
      string sentence = "The mountains are behind the clouds today";
      string oldWord = "clouds";
      string newWord = "houses";
      string result = "The mountains are behind the houses today";

      Word myPhrase = new Word(sentence, oldWord, newWord);
      //Act
      string replacement = myPhrase.Sentence.Replace(myPhrase.OldWord, myPhrase.NewWord);
      //Assert
      Assert.AreEqual(replacement, result);
    }

  }
}