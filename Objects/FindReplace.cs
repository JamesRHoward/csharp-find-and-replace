using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FindReplace.Objects
{
  public class FindAndReplace
  {
    public static string FindAndReplaceWord(string sentence, string wordToRemove, string wordToReplace)
    {
      if (sentence == null || wordToRemove == null || wordToReplace == null)
      {
        return "Please complete form";
      }
      else
      {
        System.Console.WriteLine(sentence);
        string result = Regex.Replace(sentence, Regex.Escape(wordToRemove), wordToReplace.Replace("$","$$"), RegexOptions.IgnoreCase);
        System.Console.WriteLine(result);
        return result;
      }
    }
  }
}
