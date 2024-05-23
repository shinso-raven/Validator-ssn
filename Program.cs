
string originalLine = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";
string originalLine2 = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..";
int deadAntCount = CountDeadAnts(originalLine);
Console.WriteLine($"Number of dead ants: {deadAntCount}");

static int CountDeadAnts(string antLine)
{
  int deadAnts = 0;
  if (antLine == null)
  {
    return 0;
  }
  for (int i = 0; i < antLine.Length; i++)
  {
    if (i - 1 >= 0)
    {

      if (antLine[i] == 'n' && antLine[i - 1] == '.')
        if (i + 1 < antLine.Length && antLine[i + 1] == 'a')
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



    if (antLine[i] == 'a')
    {
      if (i + 1 < antLine.Length && antLine[i + 1] == 'n' && i + 2 < antLine.Length && antLine[i + 2] == 't')
      {
        continue;
      }
      else
      {
        deadAnts++;
      }
    }
  }

  return deadAnts;
}
// Example usage




