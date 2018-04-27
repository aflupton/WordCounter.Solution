using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace WordCounterApp.Models
{
  public class RepeatCounter
  {
    private string _userString;
    private string _userWord;
    private int _occurrences = 0;

    public RepeatCounter(string userString, string userWord)
    {
      _userString = userString.ToLower();
      _userWord = userWord.ToLower();
    }

    public string GetString()
    {
      return _userString;
    }

    public void SetString(string newString)
    {
      _userString = newString;
    }

    public string GetWord()
    {
      return _userWord;
    }

    public void SetWord(string newWord)
    {
      _userWord = newWord;
    }

    public int GetOccurrences()
    {
      return _occurrences;
    }

    public int GetOccurrenceValue()
    {
      foreach (string word in _userString.Split(' '))
      {
        char[] delimiterChars = { ' ', ',', '.', ':', '?', '!' };
        if(word == _userWord)
        {
          _occurrences++;
        } else {}
      }
      Console.WriteLine("Number of occurrences: " + _occurrences);
      return _occurrences;
    }

    // public void ClearAll()
    // {
    //   _userWord.Clear();
    //   _userString.Clear();
    // }

  }
}
