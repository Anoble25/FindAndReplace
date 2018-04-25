using System.Collections;
using System;

namespace FindAndReplace
{
  public class FindAndReplace
  {
    public string PerformStringReplacement(string sentence, string chosenWord, string replacementWord)
    {
      string modifiedSentence="";
      char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
      string[] words=sentence.Split(delimiterChars);

      int counter=0;

      for(int x=0; x<words.Length; x++)
      {
        if (words[x]==chosenWord){
          words[x]=replacementWord;
        } else{}

        counter++;

        Console.WriteLine("Word "+counter+":"+words[x]);

        if (x==words.Length-1){
          modifiedSentence=modifiedSentence+words[x];
        } else{
          modifiedSentence=modifiedSentence+words[x]+" ";
        }
      }

      Console.WriteLine("modified sentence is: "+modifiedSentence);

      return modifiedSentence;
    }
  }
}
