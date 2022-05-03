namespace ArrayAndHashing.Main.Validanagram
{
  public class Solution
  {
    public bool IsAnagram(string s, string t)
    {
      if (s.Length != t.Length)
        return false;

      Dictionary<char, int> sDict = new();
      Dictionary<char, int> tDict = new();
      for (int i = 0; i < s.Length; i++)
      {
        char sChar = s[i];
        char tChar = t[i];
        sDict = UpdateCharacterDictionary(sDict, sChar);
        tDict = UpdateCharacterDictionary(tDict, tChar);
      }

      return AreDictsEqual(sDict, tDict);
    }

    private bool AreDictsEqual(Dictionary<char, int> sDict, Dictionary<char, int> tDict)
    {
      bool areEqual = true;
      if (sDict.Count == tDict.Count)
      {
        foreach (var pair in sDict)
        {
          int tValue;
          if (tDict.TryGetValue(pair.Key, out tValue))
          {
            if (tValue != pair.Value)
            {
              // same values
              areEqual = false;
              break;
            }
          }
          else
          {
            // all keys present
            areEqual = false;
            break;
          }
        }
      }
      else
      {
        areEqual = false;
      }

      return areEqual;
    }

    private static Dictionary<char, int> UpdateCharacterDictionary(Dictionary<char, int> aDict, char aChar)
    {
      if (aDict.ContainsKey(aChar))
        aDict[aChar] = +1;
      else
      {
        aDict[aChar] = 1;
      }

      return aDict;
    }
  }
}