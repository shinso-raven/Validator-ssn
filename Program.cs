
string originalLine = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";
string originalLine2 = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..";
int deadAntCount = CountDeadAnts(originalLine);
Console.WriteLine($"Number of dead ants: {deadAntCount}");

static int CountDeadAnts(string antLine)
{
  int deadAnts = 0;

  // Loop through each character in the string
  for (int i = 0; i < antLine.Length; i++)
  {
    if (i - 1 >= 0)
    {

      if (antLine[i] == 'n' && antLine[i - 1] == '.')
        if (i+1 < antLine.Length && antLine[i + 1] == 'a')
        {
          continue;
        }
        else
        {

          deadAnts++;
        }
    }

    if (antLine[i] == 't' && antLine[i - 1] == '.')
    {
      deadAnts++;
    }



    // Check if the current character is 'a'
    if (antLine[i] == 'a')
    {
      // Check if the next two characters are 'n' and 't' to form a complete "ant"
      if (i + 1 < antLine.Length && antLine[i + 1] == 'n' && i + 2 < antLine.Length && antLine[i + 2] == 't')
      {
        // If it's a complete "ant", skip to the next iteration
        continue;
      }
      else
      {
        // If it's not a complete "ant", it's a dead ant
        deadAnts++;
      }
    }
  }

  return deadAnts;
}
// Example usage