using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Create a dictionary with key value pairs to
           represent words (key) and its definition (value)
          */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Tired", "The feeling before you've finished your coffee");
            wordsAndDefinitions.Add("Pumped", "The feeling after you've finished your coffee");
            wordsAndDefinitions.Add("Hungry", "The feeling of students at 11:58am");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine($"Word: AWESOME, Definition: {wordsAndDefinitions["Awesome"]}");
            Console.WriteLine($"Word: HUNGRY, Definition: {wordsAndDefinitions["Hungry"]}");

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Value} is {word.Key}");
            }
        }
    }
}
