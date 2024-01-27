using System;
using System.Data;
using System.Linq;
using System.IO;
using System.IO.Enumeration;


class Program
{
    static void Main(string[] args)
    {
      // Making a random verse object to get the reference and verse of a random
      // scripture
      RandomVerse randomVerse = new RandomVerse();
      randomVerse.RandomizeVerse("scriptures.json");
      string verse = randomVerse.GetVerse();
      Reference reference = randomVerse.GetReference();

      // using the reference and verse as arguments to call the scripture class
      Scripture scripture = new Scripture(reference, verse);

    // this program will continue to run while all of the words are not hidden
      while(!scripture.IscompletelyHidden()){

          // clears the console
          Console.Clear();

          // displaying scripture
          scripture.GetDisplayScripture();
          System.Console.WriteLine();

          // user input
          Console.Write("Press enter to continue learning or type 0 to quit: ");
          string enter = Console.ReadLine();

          if (enter == "")
          {
            // passing 5 as an argument. This line will hide 5 words from the verse
            // everytime the user press enter
            scripture.HideRandomWords(5);

          }
          else{
            break;
          }
          
        }
        Console.Clear();

        // calling the display function last time so that the last state of the
        // scripture is displayed when the program end
        scripture.GetDisplayScripture();
        

      
     
    }
}