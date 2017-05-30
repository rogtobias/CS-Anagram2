using System;
using System.Collections.Generic;

namespace AnagramProject.Objects
{
  public class Anagram
  {

    public static string CheckAnagram(string userWord, string userStringList)
    {
      List<string> newList = new List<string>();
      Dictionary<string, string> newDictionary = new Dictionary<string, string>();
      char[] userArray = userWord.ToCharArray();
      Array.Sort(userArray);
      string userString = string.Join("", userArray);

      string[] userStringArray = userStringList.Split(null);
      for (int i = 0; i < userStringArray.Length; i++) {
        newDictionary.Add(userStringArray, i)
        char[] userCharArray = userStringArray[i].ToCharArray();
        Array.Sort(userCharArray);
        Console.WriteLine(userCharArray);
        string userCharString = string.Join("", userCharArray);
        if (userString == userCharString)
        {
          Console.WriteLine("true");
          newList.Add(userCharString);
        }
        else
        {
          Console.WriteLine("false");
        }
      };
      string output = string.Join(" ", newList);
      return output;
    }
  }
}
