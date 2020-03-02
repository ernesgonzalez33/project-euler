using System;

public class Problem1 
{
  //Recursive function to get the 3 and 5 multipliers
  public static int Euler1(int current, int sum, int final)
  {
    if (current == final)
    {
      return sum;
    }
    else if (current % 3 == 0 | current % 5 == 0)
    {
      sum += current;
      current++;
      return Euler1(current, sum, final);
    }
    else
    {
      current++;
      return Euler1(current, sum, final);
    }
  }

  public static void Main(string[] args)
  {
    if (args.Length != 1)
    {
      Console.WriteLine("Just one argument");
    }
    else
    {
      int final = Convert.ToInt32(args[0]);
      int sum = 0;
      int current = 0;
      sum = Euler1(current, sum, final);
      Console.WriteLine(sum);
    }
  }
}
