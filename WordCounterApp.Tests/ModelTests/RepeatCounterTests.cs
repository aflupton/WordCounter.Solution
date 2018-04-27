using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterApp.Models;
using System;
using System.Collections.Generic;

namespace WordCounterApp.TestTools
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CheckWord_RecogWordInput_True()
    {
      //Arrange
      RepeatCounter newWord = new RepeatCounter("Here's Johnny!", "here's");
      //Act/Assert
      Assert.AreEqual("here's", newWord.GetWord());
    }

    [TestMethod]
    public void CheckString_RecogStringInput_True()
    {
      //Act/Arrange
      RepeatCounter newString = new RepeatCounter("Gambling? I'm shocked!", "shocked");
      //Assert
      Assert.AreEqual("gambling? i'm shocked!", newString.GetString());
    }

    [TestMethod]
    public void CheckInstances_OnlyWholeWord_True()
    {
      //Arrange
      RepeatCounter newWord = new RepeatCounter("We must forget if we want to go on living.", "W");
      //Act/Assert
      Assert.AreEqual(0, newWord.GetOccurrenceValue());
    }

    [TestMethod]
    public void CountInstances_OneMatch_True()
    {
      //Arrange
      RepeatCounter newWord = new RepeatCounter("Are you there?", "You");
      //Act/Assert
      Assert.AreEqual(1, newWord.GetOccurrenceValue());
    }

    [TestMethod]
    public void CountInstances_TwoMatch_True()
    {
      //Arrange
      RepeatCounter newWord = new RepeatCounter("Oh, please, monsieur.  It is a little game we play.  They put it on the bill, I tear up the bill.  It is very convenient.", "is");
      //Act/Assert
      Assert.AreEqual(2, newWord.GetOccurrenceValue());
    }

    [TestMethod]
    public void CountInstances_GlitchMatch_False()
    {
      //Arrange
      RepeatCounter newWord = new RepeatCounter("Are wE 4wak3?", "awake");
      //Act/Assert
      Assert.AreEqual(0, newWord.GetOccurrenceValue());
    }

    // public void Dispose()
    // {
    //   //Act
    //   RepeatCounter.ClearAll();
    // }
  }
}
