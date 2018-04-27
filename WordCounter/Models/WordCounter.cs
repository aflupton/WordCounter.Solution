using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace WordCounterApp.Models
{
  public class RepeatCounter
  {
    private string _userString;

    public WordCounterApp(string userString)
    {
      _userString = userString;
    }
  }
}
