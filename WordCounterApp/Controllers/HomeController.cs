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
      return View();
    }

    [HttpPost("/Submit")]
    public ActionResult Submit()
    {
      string word = Request.Form["word"];
      string sentence = Request.Form["sentence"];
      RepeatCounter newWord = new RepeatCounter(sentence, word);
      Console.WriteLine(newWord);

      return View("Index", newWord);
    }
  }
}
