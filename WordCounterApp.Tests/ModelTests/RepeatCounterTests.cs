using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterApp.Models;
using System;
using System.Collections.Generic;

namespace WordCounterApp.TestTools
{
  [TestClass]
  public class RepeatCounterTest : IDisposable
  {
    public void Dispose()
    {
      RepeatCounter.ClearAll();
    }

    [TestMethod]
    public void CheckWord_RecogWordInput_True()
    {
      RepeatCounter newWord = new RepeatCounter("Here's Johnny!", "here's");
      Assert.AreEqual("here's", newWord.GetWord());
    }

    [TestMethod]
    public void CheckString_RecogStringInput_True()
    {
      RepeatCounter newString = new RepeatCounter("Gambling? I'm shocked!", "shocked");
      Assert.AreEqual("gambling? i'm shocked!", newString.GetString());
    }

    [TestMethod]
    public void CountInstances_OneMatch_True()
    {
      RepeatCounter newWord = new RepeatCounter("Are you there?", "You");
      Assert.AreEqual(1, newWord.GetOccurrenceValue());
    }

    [TestMethod]
    public void CountInstances_TwoMatch_True()
    {
      RepeatCounter newWord = new RepeatCounter("Oh, please, monsieur.  It is a little game we play.  They put it on the bill, I tear up the bill.  It is very convenient.", "is");
      Assert.AreEqual(2, newWord.GetOccurrenceValue());
    }
  }
}
