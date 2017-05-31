using Nancy;
using AnagramProject.Objects;
using System.Collections.Generic;

  namespace AnagramProject
  {
    public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get["/"] = _ => View["index.cshtml"];

        Post["/confirmation"] = _ => {
          string output = Anagram.CheckAnagram(Request.Form["user-word"], Request.Form["user-list"]);
          return View["index.cshtml", output];
        };
      }
    }
  }
