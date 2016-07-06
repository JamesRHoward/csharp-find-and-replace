using System;
using System.Collections.Generic;
using Xunit;
using FindReplace.Objects;

namespace FindReplace
{
  public class FindReplaceTest
  {
    [Fact]
    public void FindReplace_World_Universe()
    {
      string testSentence = "Hello worldnews .World cat dog can world";
      string testWordRemove = "world";
      string testWordReplace = "universe";
      string answer = "Hello universenews .universe cat dog can universe";
      string testResult = FindAndReplace.FindAndReplaceWord(testSentence, testWordRemove, testWordReplace);
      Assert.Equal(answer, testResult);

    }
  }
}
