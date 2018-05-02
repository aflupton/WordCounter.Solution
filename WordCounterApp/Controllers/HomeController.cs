using System;
using System.Collections.Generic;
using WordCounterApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace WordCounterApp.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View(); //return empty form
    }

    [HttpPost("/")]
    public ActionResult Submit()
    {
      string sentence = Request.Form["sentence"]; //collect string
      string word = Request.Form["word"]; //collect search word
      RepeatCounter newWord = new RepeatCounter(sentence, word); //instantiate new object
      Console.WriteLine(newWord); //check result
      return View("Index", newWord); //return result to index view
    }
  }
}
