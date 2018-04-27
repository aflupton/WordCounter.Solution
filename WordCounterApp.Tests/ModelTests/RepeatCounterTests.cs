using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterApp.Models;
using System;
using System.Collections.Generic;

namespace WordCounterApp.TestTools
{
  [TestClass]
  public class WordCounterAppTest
  {
    [TestMethod]
    public void OneMatch()
    {
      RepeatCounter newWord = new RepeatCounter("You", "Are you there?");
      Assert.AreEqual(1, newWord.GetOccurrenceValue());
    }
  }
}
