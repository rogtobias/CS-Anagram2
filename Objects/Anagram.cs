using System;
using System.Collections.Generic;

namespace AnagramProject.Objects
{
  public class Anagram
  {
    public static string CheckAnagram(string userWord, string userStringList)
    {
      List<string> matches = new List<string>();
      char[] userArray = userWord.ToCharArray();
      Array.Sort(userArray);
      string userString = string.Join("", userArray);

      string[] userStringArray = userStringList.Split(null);
      for (int i = 0; i < userStringArray.Length; i++)
      {
        char[] userCharArray = userStringArray[i].ToCharArray();
        Array.Sort(userCharArray);
        string userCharString = string.Join("", userCharArray);
        if (userString == userCharString)
        {
          matches.Add(userStringArray[i]);
        }
      }
      string output = string.Join(" ", matches);
      return output;
    }
  }
}
