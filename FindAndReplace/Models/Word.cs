using System;
using System.Collections.Generic;

namespace FindAndReplace.Models
{
  public class Word
  {
    public string Sentence { get; set; }
    public string OldWord { get; }
    public string NewWord { get; }
    public Word(string sentence, string oldWord, string newWord)
    {
      Sentence = sentence;
      OldWord = oldWord;
      NewWord = newWord;
    }

  }
}