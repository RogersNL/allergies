using System;
using System.Collections.Generic;

namespace Allergies
{
  public class Allergies
  {
    public int enteredScore;
    public Allergies(int score)
    {
      enteredScore = score;
    }
    Dictionary<int, string> allergyDictionary = new Dictionary<int, string>()
    {
      {1, "eggs"},
      {2, "peanuts"},
      {4, "shellfish"},
      {8, "strawberries"}
      {16, "tomatoes"},
      {32, "chocolate"},
      {64, "pollen"},
      {128, "cat"}
    };
    public void DetermineAllergies()
    {
      if (enteredScore >= 255)
      {
        Console.WriteLine("Allergic")
      } else if (enteredScore >= 128)
      {

      } else if (enteredScore >= 64)
      {

      } else if (enteredScore >= 32)
      {

      } else if (enteredScore >= 16)
      {

      } else if (enteredScore >= 8)
      {

      } else if (enteredScore >= 4)
      {

      } else if (enteredScore >= 2)
      {

      } else if (enteredScore >= 1)
      {

      }
    }

  }
}
