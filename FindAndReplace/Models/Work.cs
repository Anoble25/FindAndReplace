using System.Collections;
using System;

namespace FindAndReplace.Models
{
  public class Work
  {
    private string _sentence;
    private string _chosenWord;
    private string _replacementWord;

    public Work (string sentence1, string chosenWord1, string replacementWord1)
    {
      _sentence=sentence1;
      _chosenWord=chosenWord1;
      _replacementWord=replacementWord1;
    }

    public string GetOriginalSentence()
    {
      return _sentence;
    }

    public string GetChosenWord(){
      return _chosenWord;
    }

    public string GetReplacementWord(){
      return _replacementWord;
    }

    public static string PerformStringReplacement(Work newWork)
    {
      string sentence=newWork.GetOriginalSentence();
      string chosenWord=newWork.GetChosenWord();
      string replacementWord=newWork.GetReplacementWord();

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

    // public static string PerformStringReplacement(string sentence, string chosenWord, string replacementWord)
    // {
    //   string modifiedSentence="";
    //   char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
    //   string[] words=sentence.Split(delimiterChars);
    //
    //   int counter=0;
    //
    //   for(int x=0; x<words.Length; x++)
    //   {
    //     if (words[x]==chosenWord){
    //       words[x]=replacementWord;
    //     } else{}
    //
    //     counter++;
    //
    //     Console.WriteLine("Word "+counter+":"+words[x]);
    //
    //     if (x==words.Length-1){
    //       modifiedSentence=modifiedSentence+words[x];
    //     } else{
    //       modifiedSentence=modifiedSentence+words[x]+" ";
    //     }
    //   }
    //
    //   Console.WriteLine("modified sentence is: "+modifiedSentence);
    //
    //   return modifiedSentence;
    // }
  }
}
