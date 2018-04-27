using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace WordCounterApp.Models
{
  public class RepeatCounter
  {
    private string _userString;
    private string _userWord;
    private int _occurrence = 0;

    public RepeatCounter(string userString, string userWord)
    {
      _userString = userString.ToLower();
      _userWord = userWord.ToLower();
    }

    public string GetString()
    {
      return _userString;
    }

    public string GetWord()
    {
      return _userWord;
    }

    public int GetOccurrenceValue()
    {
      foreach (string word in _userString.Split())
      {
        if(word == _userWord)
        {
          _occurrence++;
        }
      }
      return _occurrence;
    }

    public void ClearAll()
    {
      _userString = "";
      _userWord = "";
      _occurrence = 0;
    }

  }
}
