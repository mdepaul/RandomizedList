# RandomizedList
C# library to randomize arbitrary object types via Generics. Add objects to the list, and read them out in a cryptographically strong pseudo-random order.

Useage example:

```     
  public string ShuffleString(StringBuilder sb)
  {
      RandomizedList<char> rando = new RandomizedList<char>(Prng);
      for (int i = 0; i < sb.Length; i++)
      {
          rando.Add(sb[i]);
      }

      sb.Clear();
      foreach (var item in rando)
      {
          sb.Append(item);
      }
      return sb.ToString();
  }
```
See https://github.com/mdepaul/XRng.git for Prng useage. It is required to provide the internal randomization functionality of RandomizedList.
